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

        public int AcceptRequest(string requestId)
        {
            RequestDetail reqDetail = myContext.RequestDetails.Where(rd => rd.RequestId == requestId).FirstOrDefault();
            reqDetail.Status = StatusRequestDetail.Accepted;

            var result = myContext.SaveChanges();

            if (result > 0 && result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int RejectRequest(string requestId)
        {
            RequestDetail reqdet = myContext.RequestDetails.Where(rd => rd.RequestId == requestId).FirstOrDefault();
            reqdet.Status = StatusRequestDetail.Rejected;

            var result = myContext.SaveChanges();

            if (result > 0 && result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int CreateRequestDetail(CreateRequestDetailVM createRequestDetailVM)
        {
            var requestDetail = new RequestDetail()
            {
                Note = createRequestDetailVM.Note,
                Date = Convert.ToString(DateTime.Now.Date),
                RequestId = createRequestDetailVM.RequestId,
                EmployeeId = createRequestDetailVM.EmployeeId
            };

            if (createRequestDetailVM.Status == "1")
            {
                requestDetail.Status = StatusRequestDetail.Accepted;
            }
            if (createRequestDetailVM.Status == "2")
            {
                requestDetail.Status = StatusRequestDetail.Rejected;
            }


            //Send email
            Request request = myContext.Requests.Where(r => r.Id == createRequestDetailVM.RequestId).FirstOrDefault();
            string requesterId = request.RequesterId;

            Employee employee = myContext.Employees.Where(e => e.NIK == requesterId).FirstOrDefault();
            string email = employee.Email;

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
