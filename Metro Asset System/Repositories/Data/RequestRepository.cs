using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using Metro_Asset_System.Handler;
using Metro_Asset_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using Metro_Asset_System.Content;
using Microsoft.EntityFrameworkCore;

namespace Metro_Asset_System.Repositories.Data
{
    public class RequestRepository : GeneralRepository<Request, MyContext, string>
    {
        private readonly MyContext myContext;       
        private readonly TransactionContent transactionContent = new TransactionContent();
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

            //start generate request id
            int max = 0;
            var now = "RQT" + DateTime.Now.ToString("yy");            
            var data = myContext.Requests.OrderByDescending(r => r.Id).Where(r => r.Id.Contains(now)).Select(s => new { Id = s.Id }).FirstOrDefault();
            if (data != null)
            {
                max = Convert.ToInt32(data.Id.Substring(5));//get max increment id in database          
            }
            string requestId = generator.GenerateRequestId(max);//generate
            //end generate request id


            //insert to request table
            var request = new Request()
            {
                Id = requestId,
                RequestDate = DateTime.Now.Date,
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

                if (resultItemRequest > 0) {
                    success+=1; //menghitung jumlah insert yang berhasil
                }
            }
            //end insert itemrequest


            //start set email requirement
            var requestData = myContext.Requests.Where(r => r.Id == requestId).FirstOrDefault();//get request data   
            var employeeData = myContext.Employees.Where(r => r.NIK == requestData.RequesterId).FirstOrDefault();//get employee data   

            string[,] listItem = new string[requestData.ItemRequest.Count(),2];
            int listItemIndex= 0;
            foreach (var row in requestData.ItemRequest)
            {
                listItem[listItemIndex, 0] = row.Asset.Id;
                listItem[listItemIndex, 1] = row.Asset.Name;
                listItemIndex++;
            }
            var reqData= new[] {requestId,requestVM.StartDate.ToString("dd/MM/yyyy"),requestVM.EndDate.ToString("dd/MM/yyyy") };
            var emailIdentity = new[] { employeeData.Email, employeeData.FirstName};
            //end set email requirement

            if (resultRequest > 0 && success==sumAsset)
            {
                transactionContent.Request(emailIdentity,reqData, listItem);
                return 1;
            }
            else {
                return 0;
            }
        }

        public int UpdateApprovalStatus(ManageRequestVM manageRequestVM) 
        {
            Request request = myContext.Requests.Where(r => r.Id == manageRequestVM.RequestId).FirstOrDefault();
            Employee employee = myContext.Employees.Where(e => e.NIK == manageRequestVM.EmployeeId).FirstOrDefault();

            if (manageRequestVM.RequestDetailStatus == "2")
            {
                request.Status = Status.Inactive;
            }
            else 
            {
                if (employee.Role == EmployeeRole.Employee_Manager)
                {
                    request.RequestStatus = RequestStatus.Approve_Level_2;
                }
                else if (employee.Role == EmployeeRole.Procurement_Manager)
                {
                    request.RequestStatus = RequestStatus.Approved;
                }
            }
            myContext.Entry(request).State = EntityState.Modified;

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

        public IEnumerable<Request> GetByConditon(string condition, string requesterid)//for employee and procurement employee
        {
            if (requesterid == null)// untuk procurement employee, get tanpa requester 
            {
                if (condition == "incoming")
                {
                    var data = myContext.Requests.Where(r => r.Status == Status.Active && r.RequestStatus == RequestStatus.Approved);
                    return data;
                }
                else //processed
                {
                    var data = myContext.Requests.Where(r => r.Status == Status.Active && r.RequestStatus == RequestStatus.Processed);
                    return data;
                }

            }
            else {
                if (condition == "current") //current
                {
                    var data = myContext.Requests.Where(r => r.Employee.NIK == requesterid && r.Status == Status.Active && r.RequestStatus != RequestStatus.Processed);
                    return data;
                }
                else if (condition == "ongoing") //ongoing
                {
                    var data = myContext.Requests.Where(r => r.Employee.NIK == requesterid && r.Status == Status.Active && r.RequestStatus == RequestStatus.Processed);
                    return data;
                }
                else //rejected
                {
                    var data = myContext.Requests.Where(r => r.Employee.NIK == requesterid && r.Status == Status.Inactive);
                    return data;
                }
            }           
        }

        public IEnumerable<Request> GetByConditionManager(string level,string condition, string managerid)//for manager
        {
            if (level == "1" && condition=="incoming")
            {
                var data = myContext.Requests.Where(r => r.Employee.ManagerId == managerid && r.Status == Status.Active && r.RequestStatus == RequestStatus.Approve_Level_1);
                return data;
            }
            else if (level=="1" && condition == "approved")
            {
                var data = myContext.Requests.Where(r => r.Employee.ManagerId == managerid && r.Status == Status.Active && r.RequestStatus == RequestStatus.Approve_Level_2);
                return data;
            }
            else if (level == "1" && condition == "rejected")
            {
                var data = myContext.Requests.Where(r => r.Employee.ManagerId == managerid && r.Status == Status.Inactive && r.RequestStatus == RequestStatus.Approve_Level_1);
                return data;
            }
            else if (level == "2" && condition == "incoming")
            {
                var data = myContext.Requests.Where(r =>  r.Status == Status.Active && r.RequestStatus == RequestStatus.Approve_Level_2);
                return data;
            }
            else if (level == "2" && condition == "approved")
            {
                var data = myContext.Requests.Where(r =>  r.Status == Status.Active && r.RequestStatus == RequestStatus.Approved);
                return data;
            }
            else if (level == "2" && condition == "rejected")
            {
                var data = myContext.Requests.Where(r =>  r.Status == Status.Inactive && r.RequestStatus == RequestStatus.Approve_Level_2);
                return data;
            }
            else
            {
                var data = myContext.Requests.Where(r => r.Employee.NIK == managerid && r.Status == Status.Inactive);
                return data;
            }
        }
    }
}
