using Metro_Asset_System.Context;
using Metro_Asset_System.Handler;
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
        private readonly SendEmail sendEmail = new SendEmail();

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

        public int ManageRequest(bool accepted, ManageRequestVM manageRequestVM)
        {
            var resultCreateDetail = this.CreateRequestDetail(manageRequestVM);
            var resultUpdateStatus = requestRepository.UpdateApprovalStatus(manageRequestVM);

            Request req = myContext.Requests.Where(r => r.Id == manageRequestVM.RequestId).FirstOrDefault();
            Employee emp = myContext.Employees.Where(e => e.NIK == req.RequesterId).FirstOrDefault();
            RequestDetail reqDet = myContext.RequestDetails.OrderByDescending(rd => rd.Id).FirstOrDefault();

            var subject = "";
            var email = emp.Email;
            var message = "";
            var status = "";

            if (manageRequestVM.RequestDetailStatus == "1")
            {
                subject = "Request Accepted";
                status = "Accepted";
            }
            else 
            {
                subject = "Request Accepted";
                status = "Rejected";
            }
            message = "<h3>Hello " + emp.FirstName + ", </h3>";
            message += "<br><p>There is an update with your request. Here is the detail: </p>";
            message += "<br><table>" +
                            "<tr>" +
                            "<td>Request Code</td>" +
                            "<td>: " + req.Id + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td>Start Date</td>" +
                            "<td>: " + req.LoanDate + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td>End Date</td>" +
                            "<td>: " + req.ReturnDate + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td>Requested at</td>" +
                            "<td>: " + req.RequestDate + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td>Status</td>" +
                            "<td>: " + status + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td>Notes</td>" +
                            "<td>: " + reqDet.Note + "</td>" +
                            "</tr>" +
                        "</table>";
            message += "<br><p>Please check the details by signing in the MetroAssets System.</p>";
            message += "<br>Best Regards, MetroAssets Staff<br>";

            //set email requerement
            var data = new[] { email, subject, message };
            if (resultCreateDetail > 0 && resultUpdateStatus > 0) 
            {
                sendEmail.Send(data);
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
                Status = StatusRequestDetail.NotSet,
                Note = manageRequestVM.Note,
                Date = Convert.ToString(DateTime.Now),
                RequestId = manageRequestVM.RequestId,
                EmployeeId = manageRequestVM.EmployeeId
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
    }
}
