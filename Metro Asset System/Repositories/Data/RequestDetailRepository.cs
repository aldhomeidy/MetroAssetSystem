using Metro_Asset_System.Content;
using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class RequestDetailRepository : GeneralRepository<RequestDetail, MyContext, int>
    {
        private readonly MyContext myContext;
        private readonly RequestRepository requestRepository;
        private readonly EmployeeRepository employeeRepository;        
        private readonly TransactionContent transactionContent = new TransactionContent();

        public IConfiguration Configuration { get; }

        public RequestDetailRepository(MyContext myContext, EmployeeRepository employeeRepository,
            RequestRepository requestRepository, IConfiguration configuration) : base(myContext)
        {
            myContext.Set<RequestDetail>();

            this.myContext = myContext;
            this.employeeRepository = employeeRepository;
            this.requestRepository = requestRepository;
            this.Configuration = configuration;
        }

        #region Transaction 

        public int ManageRequest(bool accepted, ManageRequestVM manageRequestVM)
        {
            Request request = myContext.Requests.Where(r => r.Id == manageRequestVM.RequestId).FirstOrDefault();            
            RequestDetail requestDetail = myContext.RequestDetails.Where(rd=>rd.RequestId==manageRequestVM.RequestId).OrderByDescending(rd => rd.Id).FirstOrDefault();
            Employee employee = myContext.Employees.Where(e => e.NIK == manageRequestVM.EmployeeId).FirstOrDefault();

            var role = "";
            if (employee.Role == EmployeeRole.Employee_Manager)
            {
                role = "1";
            }
            else {
                role = "2";
            }

            var resultCreateDetail = this.CreateRequestDetail(manageRequestVM); //add request detail data
            var resultUpdateStatus = requestRepository.UpdateApprovalStatus(manageRequestVM); //update request data

            //set email requirement
            var identity = new[] { request.Employee.FirstName, request.Employee.Email, manageRequestVM.RequestDetailStatus, manageRequestVM.Note, role};

            if (resultCreateDetail > 0 && resultUpdateStatus > 0) 
            {
                //transactionContent.ManageRequest(identity,request);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int CreateRequestDetail(ManageRequestVM manageRequestVM)
        {
            var requestDetail = new RequestDetail()
            {
                Note = manageRequestVM.Note,
                Date =DateTime.Now.Date,
                RequestId = manageRequestVM.RequestId,
                EmployeeId = manageRequestVM.EmployeeId,
                Status = StatusRequestDetail.NotSet
            };
            
            if (manageRequestVM.RequestDetailStatus == "1")
            {
                requestDetail.Status = StatusRequestDetail.Accepted;
            }
            else 
            {
                requestDetail.Status = StatusRequestDetail.Rejected;
            }

            myContext.Add(requestDetail);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region Get Data
        public IEnumerable<RequestDetail> GetByCondition(string condition, string requesterId) { //for requester 
            if (condition == "rejected")
            {
                var data = myContext.RequestDetails.Where(rd => rd.Request.RequesterId == requesterId && rd.Status == StatusRequestDetail.Rejected);
                return data;
            }
            else if (condition == "accepted")
            {
                var data = myContext.RequestDetails.Where(rd => rd.Request.RequesterId == requesterId && rd.Status == StatusRequestDetail.Accepted);
                return data;
            }
            else {
                var data = myContext.RequestDetails.Where(rd => rd.Request.RequesterId == requesterId && rd.Status == StatusRequestDetail.NotSet);
                return data;
            }
        }
        #endregion
    }
}
