using Metro_Asset_System.Base.Controller;
using Metro_Asset_System.Models;
using Metro_Asset_System.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Controllers
{
    // Edward
    // [Route("api/[controller]")]
    // [ApiController]
    public class InvoiceController : BaseController<Invoice, InvoiceRepository, string>
    {
        private readonly InvoiceRepository invoiceRepository;

        public InvoiceController(InvoiceRepository invoiceRepository): base(invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }

        // Edward
        // [HttpGet("GetInvoice/{status}")]
        // public ActionResult GetInvoice(string onGoing)
        // {
        //     var data = invoiceRepository.GetByStatus(onGoing);
        //     if (data != null)
        //     {
        //         return Ok(new { data = data, status = "Ok" });
        //     }
        //     else
        //     {
        //         return StatusCode(500, new { data = data, status = "Internal server error" });
        //     }
        // }

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
    }
}
