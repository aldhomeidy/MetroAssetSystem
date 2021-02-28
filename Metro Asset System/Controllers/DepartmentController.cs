using MAS.Client.ViewModels;
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
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : BaseController<Department, DepartmentRepository, string>
    {
        DepartmentRepository departmentRepository;
        public DepartmentController(DepartmentRepository departmentRepository):base(departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpPost("SubmitDepartment")]
        public ActionResult SubmitDepartment(DepartmentVM departmentVM)
        {
            var data = departmentRepository.Create(departmentVM);
            if (data == 1)
            {
                return Ok(new { status = "Submit Success" });
            }
            else
            {
                return StatusCode(500, new { status = "Internal Server Error" });
            }
        }

        [HttpPut("UpdateDepartment")]
        public ActionResult UpdateDepartment(DepartmentVM departmentVM)
        {
            var data = departmentRepository.Update(departmentVM);
            if (data == 1)
            {
                return Ok(new { status = "Update Success" });
            }
            else
            {
                return StatusCode(500, new { status = "Internal Server Error" });
            }
        }
    }
}
