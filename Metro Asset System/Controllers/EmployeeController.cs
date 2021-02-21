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
        public EmployeeController(EmployeeRepository employeeRepository, RequestRepository requestRepository):base(employeeRepository)
        {
            this.employeeRepository = employeeRepository;
            this.requestRepository = requestRepository;
        }

        [HttpPost("Request")]
        public ActionResult CreateRequest(RequestVM requestVM) {
            var data = requestRepository.Create(requestVM);
            if (data == 1)
            {
                return Ok(new { status = "Request successed..." });
            }
            else {
                return StatusCode(500,new { status = "Internal Server Error..." });
            }
        }
    }
}
