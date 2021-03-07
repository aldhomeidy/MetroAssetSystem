using Metro_Asset_System.Base.Controller;
using Metro_Asset_System.Models;
using Metro_Asset_System.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Controllers
{
    public class InvoiceController : BaseController<Invoice, InvoiceRepository, string>
    {
        private readonly InvoiceRepository invoiceRepository;

        public InvoiceController(InvoiceRepository invoiceRepository): base(invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }

        [HttpGet("data/{condition}")]
        public ActionResult GetInvoice(string condition)
        {

            var data = invoiceRepository.GetByCondition(condition);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return StatusCode(500, data);
            }
        }

        [HttpGet("history/{requesterId}/{condition}")]
        public ActionResult GetByRequester(string requesterId,string condition)
        {

            var data = invoiceRepository.GetByRequester(requesterId, condition);
            if(data!=null)
            {
                return Ok(data);
            }
            else
            {
                return StatusCode(500, data);
            }
        }
    }
}
