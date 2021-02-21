using Metro_Asset_System.Context;
using Metro_Asset_System.Content;
using Metro_Asset_System.Handler;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Metro_Asset_System.Repositories.Data
{
    public class InvoiceRepository : GeneralRepository<Invoice, MyContext, int>
    {
        private readonly MyContext myContext;
        private readonly Generator generator = new Generator();
        private readonly TransactionContent transactionContent = new TransactionContent();
        private readonly PinaltyHistoryRepository pinaltyHistoryRepository;
        private readonly AssetRepository assetRepository;

        public InvoiceRepository(MyContext myContext, PinaltyHistoryRepository pinaltyHistoryRepository, AssetRepository assetRepository) : base(myContext)
        {
            this.myContext = myContext;
            this.pinaltyHistoryRepository = pinaltyHistoryRepository;
            this.assetRepository = assetRepository;
        }

        public int CreateInvoice(CreateInvoiceVM createInvoiceVM)
        {
            int max = 0;
            var now = "INV" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy");
            var data = myContext.Invoices.OrderByDescending(i => i.Id).Where(i => i.Id.Contains(now)).Select(i => new { Id = i.Id }).FirstOrDefault();
            if (data != null)
            {
                max = Convert.ToInt32(data.Id.Substring(7), data.Id.Length - 7);
            }

            string invoiceId = generator.GenerateInvoiceId(max);

            var invoice = new Invoice()
            {
                Id = invoiceId,
                Status = StatusInvoice.On_Going,
                InvoiceDate = DateTime.Now.Date,
                RequestId = createInvoiceVM.RequestId,
                ProcurementEmployeeId = createInvoiceVM.ProcurementEmployeeId
            };

            myContext.Add(invoice);

            var resultInvoice = myContext.SaveChanges();//create invoice
            
            Request request = myContext.Requests.Where(r => r.Id == createInvoiceVM.RequestId).FirstOrDefault();
            Employee employee = myContext.Employees.Where(e => e.NIK == createInvoiceVM.ProcurementEmployeeId).FirstOrDefault();
            request.RequestStatus = RequestStatus.Processed;
            var resultRequest = myContext.SaveChanges();//update request status


            //firstname, email, procurement staff name           
            var identity = new[] { request.Employee.FirstName, request.Employee.Email, employee.FirstName };
            if (resultInvoice > 0)
            {
                transactionContent.Invoice(identity,invoice);
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        public int ReturnAssets(ReturnAssetsVM returnAssetsVM) 
        {
            //start merubah status invoice
            var invoice = myContext.Invoices.Where(i => i.Id == returnAssetsVM.InvoiceId).FirstOrDefault();  
            invoice.Id = returnAssetsVM.InvoiceId;
            if (returnAssetsVM.StatusInvoice == "1")
            {
                invoice.Status = StatusInvoice.Finished_Fine;
            }
            else 
            {
                invoice.Status = StatusInvoice.Finished_With_Problem;
            }         
            var result = myContext.SaveChanges();
            //end merubah status invoice


            //start merubah status request jadi inactive
            var request = myContext.Requests.Where(r => r.Id == invoice.RequestId).FirstOrDefault();
            request.Id = invoice.Request.Id;
            request.Status = Status.Inactive;
            var resultRequest = myContext.SaveChanges();
            //end merubah status request jadi inactive


            long sumPinalty = 0;//variabel untuk menampung jumlah pinalty
            var assetStatus = "";//variabel untuk menampung status return asset


            //set email requirement          
            string[,] listItem = new string[invoice.Request.ItemRequest.Count(), 4]; //value : id, name, return condition, pinalty
            for (int i = 0;i< invoice.Request.ItemRequest.Count();i++) {
                //start update kondisi asset
                if (returnAssetsVM.Assets[i, 1] == "1" || returnAssetsVM.Assets[i, 1] == "2" || returnAssetsVM.Assets[i, 1] == "3")
                {
                    assetStatus = "1";//problem
                }
                else if (returnAssetsVM.Assets[i, 1] == "4") 
                {
                    assetStatus = "3";//lost
                }
                else
                {
                    assetStatus = "0";//fine
                }
                assetRepository.UpdateAssetCondition(returnAssetsVM.Assets[i, 0], assetStatus);
                //end update kondisi asset

                if (assetStatus == "0")//jika kondisinya fine
                {
                    assetRepository.UpdateStatus(returnAssetsVM.Assets[i, 0], true); //update semua status asset jadi available
                }
                //jika tidak, maka statusnya tetap unavailable


                //start sum pinalty and set email requirement
                var pinalty = myContext.Pinalties.Where(p => p.AssetId == returnAssetsVM.Assets[i,0]).FirstOrDefault();
                listItem[i, 0] = pinalty.Asset.Id;
                listItem[i, 1] = pinalty.Asset.Name;
                switch (returnAssetsVM.Assets[i, 1])
                {
                    case "1":
                        sumPinalty += pinalty.LowPinalty; //damaged low
                        listItem[i, 2] = "Low Damaged";
                        listItem[i, 3] = pinalty.LowPinalty.ToString();
                        break;
                    case "2":
                        sumPinalty += pinalty.MiddlePinalty; //damaged middle
                        listItem[i, 2] = "Middle Damaged";
                        listItem[i, 3] = pinalty.MiddlePinalty.ToString();
                        break;
                    case "3":
                        sumPinalty += pinalty.HighPinalty; //damaged high
                        listItem[i, 2] = "High Damaged";
                        listItem[i, 3] = pinalty.HighPinalty.ToString();
                        break;
                    case "4":
                        sumPinalty += pinalty.LostPinalty; //asset lost
                        listItem[i, 2] = "Asset Lost";
                        listItem[i, 3] = pinalty.LostPinalty.ToString();
                        break;
                    default:
                        sumPinalty += 0;
                        listItem[i, 2] = "Fine";
                        listItem[i, 3] = "0";
                        break;
                }
                //end sum pinalty
            }

            //start create pinalty data
            var pinaltyData = new PinaltyHistory()
            {
                InvoiceId = returnAssetsVM.InvoiceId,
                Pinalty = sumPinalty,
                PinaltyDate = DateTime.Now.Date
            };
            var createPinalty = pinaltyHistoryRepository.Create(pinaltyData);
            //end create pinalty data


            if (result > 0 && createPinalty > 0)
            {
                transactionContent.Return(invoice,listItem,sumPinalty.ToString());
                return 1;
            }
            else { 
                return 0;
            }
        }
    }
}
