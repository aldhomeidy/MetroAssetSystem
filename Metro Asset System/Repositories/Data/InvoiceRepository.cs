using Metro_Asset_System.Context;
using Metro_Asset_System.Handler;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class InvoiceRepository : GeneralRepository<Invoice, MyContext, int>
    {
        private readonly MyContext myContext;
        private readonly Generator generator = new Generator();

        public InvoiceRepository(MyContext myContext) : base(myContext)
        {
            this.myContext = myContext;
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

            string invoiceId = generator.GenerateRequestId(max);

            var invoice = new Invoice()
            {
                Id = invoiceId,
                Status = StatusInvoice.On_Going,
                InvoiceDate = DateTime.Now.ToString("dd-MM-yyyy"),
                RequestId = createInvoiceVM.RequestId,
                ProcurementEmployeeId = createInvoiceVM.ProcurementEmployeeId
            };

            myContext.Add(invoice);

            var resultInvoice = myContext.SaveChanges();

            if (resultInvoice > 0)
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
