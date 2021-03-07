using Metro_Asset_System.Base.Controller;
using Metro_Asset_System.Models;
using Metro_Asset_System.Repositories.Data;
using Metro_Asset_System.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController<Employee, EmployeeRepository, string>
    {
        private readonly EmployeeRepository employeeRepository;
        private readonly RequestRepository requestRepository;
        private readonly InvoiceRepository invoiceRepository;
        private readonly RequestDetailRepository requestDetailRepository;

        public EmployeeController(EmployeeRepository employeeRepository, RequestRepository requestRepository, RequestDetailRepository requestDetailRepository, InvoiceRepository invoiceRepository) :base(employeeRepository)
        {
            this.employeeRepository = employeeRepository;
            this.requestRepository = requestRepository;
            this.requestDetailRepository = requestDetailRepository;
            this.invoiceRepository = invoiceRepository;
        }

        [HttpPost("Request")]
        public ActionResult CreateRequest(RequestVM requestVM) 
        {
            var data = requestRepository.Create(requestVM);
            if (data == 1)
            {
                return Ok(new { status = "Request successed..." });
            }
            else {
                return StatusCode(500,new { status = "Internal Server Error..." });
            }
        }

        [HttpPut("ManageRequest")]
        public ActionResult ManageRequest(ManageRequestVM manageRequestVM)
        {
            bool accepted = true;
            string notif = "Accept";

            if (manageRequestVM.RequestDetailStatus == "2")
            {
                accepted = false;
                notif = "Reject";
            }
            var data = requestDetailRepository.ManageRequest(accepted, manageRequestVM);
            if (data > 0)
            {
                return Ok(new {status = notif + " Request Successed..." });
            }
            else
            {
                return StatusCode(500, new {status = "Internal server error..." });
            }
        }      

        [HttpPost("Invoice")]
        public ActionResult CreateInvoice(CreateInvoiceVM createInvoiceVM)
        {
            var data = invoiceRepository.CreateInvoice(createInvoiceVM);
            if (data > 0)
            {
                return Ok(new { status = "Create Invoice Successed..." });
            }
            else
            {
                return StatusCode(500, new { status = "Internal server error..." });
            }
        }

        [HttpPost("Return")]
        public ActionResult ReturnAssets(ReturnAssetsVM returnAssetsVM)
        {
            var data = invoiceRepository.ReturnAssets(returnAssetsVM);
            if (data > 0)
            {
                return Ok(new { status = "Assets has been returned..." });
            }
            else
            {
                return StatusCode(500, new { status = "Internal server error..." });
            }
        }

        [HttpGet("subordinate/{managerId}")]
        public ActionResult GetSubordinate(string managerId) {
            var data = employeeRepository.GetSubordinate(managerId);
            if (data !=null)
            {
                return Ok(new {data});
            }
            else
            {
                return StatusCode(500, new { status = "Internal server error..." });
            }
        }

        [HttpGet("data/requester")]
        public ActionResult GetRequester() {
            var data = employeeRepository.GetRequester();
            if (data != null)
            {
                return Ok(new { data });
            }
            else
            {
                return StatusCode(500, new { status = "Internal server error..." });
            }
        }
    }
}
