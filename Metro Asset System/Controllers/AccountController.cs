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
    public class AccountController : BaseController<Account, AccountRepository, string>
    {
        private readonly AccountRepository accountRepository;
        private readonly EmployeeRepository employeeRepository;

        public AccountController(AccountRepository accountRepository, EmployeeRepository employeeRepository) : base(accountRepository)
        {
            this.accountRepository = accountRepository;
            this.employeeRepository = employeeRepository;
        }

        [HttpPost("Register")]
        public ActionResult Register(RegisterVM registerVM)
        {
            var data = accountRepository.Register(registerVM);
            if (data > 0)
            {
                return Ok(new {data=data, status = "Registration Successed..." });
            }
            else
            {
                return StatusCode(500, new { data = data, status = "Internal server error..." });
            }
        }

        [HttpPost("Login")]
        public ActionResult Login(LoginVM loginVM) {
            var data = accountRepository.Login(loginVM.Username,loginVM.Password);
            switch (data)
            {
                case 1:
                    return Ok(new { status = "Login Successed..." });
                case 2:
                    return StatusCode(403,new { status = "Your email was not verificated..." });
                case 3:
                    return StatusCode(403, new { status = "Incorrect password..." });
                case 4:
                    return StatusCode(403, new { status = "Username was not registered..." });
                default:
                    return NotFound(new { status = "Account is not identified..." });
            }
        }

        [HttpGet("Verify/{nik}")]
        public ActionResult VerifyEmail(string nik)
        {
            var data = accountRepository.Verificate(nik);
            if (data != 0)
            {
                return Ok(new { status = "Email verificated..." });
            }
            else {
                return StatusCode(500, new { status = "Internal server error..." });
            }
        }        
    }
}
