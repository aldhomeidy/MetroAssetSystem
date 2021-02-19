using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using Metro_Asset_System.Handler;
using Metro_Asset_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Metro_Asset_System.Repositories.Data
{
    public class RequestRepository : GeneralRepository<Request, MyContext, int>
    {
        private readonly MyContext myContext;
        private readonly SendEmail sendEmail = new SendEmail();
        private readonly Generator generator = new Generator();
        private readonly ItemRequestRepository itemRequestRepository;
        private readonly AssetRepository assetRepository;
        public RequestRepository(MyContext myContext, ItemRequestRepository itemRequestRepository, AssetRepository assetRepository) : base(myContext)
        {
            this.myContext = myContext;
            this.itemRequestRepository = itemRequestRepository;
            this.assetRepository = assetRepository;
        }
        public int Create(RequestVM requestVM) {
            int max = 0; //for condition if there is no id with this year
            var now = "RQT" + DateTime.Now.ToString("yy");
            //var data = myContext.Requests.OrderByDescending(r => r.Id).Where(r=>r.Id.Contains(now)).FirstOrDefault();
            var data = myContext.Requests.OrderByDescending(r => r.Id).Where(r => r.Id.Contains(now)).Select(s=> new { Id=s.Id}).FirstOrDefault();
            if (data != null)//if there is id with this year 
            {
                max = Convert.ToInt32(data.Id.Substring(5, data.Id.Length - 5));//get max increment           
            }

            string requestId = generator.GenerateRequestId(max);
            var employeeData = myContext.Requests.Where(r => r.Id == "RQT211").FirstOrDefault();//get employee data            

            //insert to request table
            var request = new Request()
            {
                Id = requestId,
                //RequestDate = DateTime.Now.ToString("dd-MM-yyyy"),
                LoanDate = requestVM.StartDate,
                ReturnDate = requestVM.EndDate,
                Status = Status.Active,
                RequestStatus = RequestStatus.Approve_Level_1,
                RequesterId = requestVM.RequesterId //-->get from session
            };
            myContext.Add(request);
            var resultRequest = myContext.SaveChanges();
            //end insert request

            //start insert itemrequest
            int sumAsset = requestVM.Assets.Length;
            int success = 0;
            for (int i = 0; i < sumAsset; i++) {
                var itemRequest = new ItemRequest()
                {
                    RequestId = requestId,
                    AssetId = requestVM.Assets[i]
                };
            var resultItemRequest = itemRequestRepository.Create(itemRequest);
                assetRepository.UpdateStatus(requestVM.Assets[i],false); //update status barang jadi unavailable

                if (resultItemRequest > 1) {
                    success++; //menghitung jumlah insert yang berhasil
                }
            }
            //end insert itemrequest

            //start set email requerement
            //var employeeData = myContext.Requests.Where(r => r.Id == requestId).FirstOrDefault();//get employee data            
            //var itemData = myContext.ItemRequests.Where(i => i.RequestId == requestId).ToList();            

            var subject = "Request Notification";
            var email = employeeData.Employee.Email;
            var message = "<h3>Hello " + employeeData.Employee.FirstName + ", </h3>";
            message += "<br><p>You have successed creating for loan request. Here is your details request:</p>";
            message += "<br><table>" +
                            "<tr>" +    
                            "<td>Request Code</td>" +
                            "<td>#" + requestId+ "</td>"+
                            "</tr>" +
                            "<tr>" +
                            "<td>Request Date</td>" +
                            "<td>" + DateTime.Now.ToString("dd-MM-yyyy") + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td>From</td>" +
                            "<td>" + requestVM.StartDate + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td>Until</td>" +
                            "<td>" + requestVM.EndDate + "</td>" +
                            "</tr>" +
                        "</table>";
            message += "<br><p>For your information, your request will be processed if you reach approval from Procurement Manager. So please wait until the Procurement Manager has approved your request.</p>";
            message += "<br><br>";
            message += "<p>Best Regards, <b>Metro Asset Staff</b></p>";


            var emailData = new[] { email, subject, message };
            //end set email requerement

            if (resultRequest > 0 && success == sumAsset)
            {
                return 1;
            }
            else {
                return 0;
            }
        }

        public int UpdateApprovalStatus(ManageRequestVM manageRequestVM) 
        {
            Request req = myContext.Requests.Where(r => r.Id == manageRequestVM.RequestId).FirstOrDefault();
            Employee emp = myContext.Employees.Where(e => e.NIK == manageRequestVM.EmployeeId).FirstOrDefault();

            if (manageRequestVM.RequestDetailStatus == "2")
            {
                req.Status = Status.Inactive;
            }
            else 
            {
                if (emp.Role == EmployeeRole.Employee_Manager)
                {
                    req.RequestStatus = RequestStatus.Approve_Level_2;
                }
                else if (emp.Role == EmployeeRole.Procurement_Manager)
                {
                    req.RequestStatus = RequestStatus.Approved;
                }
            }
            myContext.Entry(req).State = EntityState.Modified;

            var resultUpdate = myContext.SaveChanges();
            if (resultUpdate > 0)
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
