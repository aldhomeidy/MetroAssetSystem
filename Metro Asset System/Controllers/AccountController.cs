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
                return Ok(new {status = "Registration Successed..." });
            }
            else
            {
                return StatusCode(500, new {status = "Internal server error..." });
            }
        }

        [HttpPost("Login")]
        public ActionResult Login(LoginVM loginVM) {

            var data = accountRepository.Login(loginVM.Username,loginVM.Password);
            var employeeData = employeeRepository.GetByUsername(loginVM.Username);

            var sendData = new { NIK = employeeData.NIK, FirstName= employeeData.FirstName, Role = employeeData.Role};
            switch (data)
            {               
                case 1:
                    return Ok(sendData);
                case 2:
                    return StatusCode(403, sendData);
                case 3:
                    return StatusCode(403, sendData);
                case 4:
                    return StatusCode(403, sendData);
                default:
                    return NotFound(sendData);
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

        [HttpPut("ChangePassword")]
        public ActionResult ChangePassword(ChangePasswordVM changePasswordVM)
        {
            var acc = accountRepository.Get(changePasswordVM.NIK);
            if (acc != null)
            {
                if (BCrypt.Net.BCrypt.Verify(changePasswordVM.OldPassword, acc.Password))
                {
                    var data = accountRepository.ChangePassword(changePasswordVM.NIK, changePasswordVM.NewPassword);

                    return Ok(new { status = "Change Password Successed..." });
                }
                else
                {
                    return StatusCode(404, new { status = "404", message = "Wrong password" });
                }
            }
            return NotFound();
        }

        [HttpPut("ForgotPassword")]
        public ActionResult ForgotPassword(RegisterVM registerVM)
        {
            var data = accountRepository.ForgotPassword(registerVM.Email);
            if (data == 1)
            {
                return Ok(new {status = "Forgot Password Successed..." });
            }
            else if (data == 2) 
            {
                return NotFound(new { status = "Email not registered" });
            }
            else
            {
                return StatusCode(500, new { data = data, status = "Internal server error..." });
            }
        }

       /* [HttpPost("Check/{field}")]
        public ActionResult FieldCheck(string field, RegisterVM registerVM) 
        {
            var data = accountRepository.CheckAccountUniqueField(field, registerVM.DynamicVar);
            if (data == 1)
            {
                return Ok(new { status = "Available to use" });
            }
            else 
            {
                return StatusCode(403, new { status = "Already used" });
            }
        }*/
    }
}
