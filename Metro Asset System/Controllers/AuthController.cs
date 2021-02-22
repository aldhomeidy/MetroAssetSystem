using Metro_Asset_System.Handler;
using Metro_Asset_System.Repositories.Data;
using Metro_Asset_System.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
    public class AuthController : ControllerBase
    {
        private readonly IJWTAuthenticationManager jWTAuthenticationManager;
        private readonly AccountRepository accountRepository;
        public AuthController(IJWTAuthenticationManager jWTAuthenticationManager, AccountRepository accountRepository)
        {
            this.jWTAuthenticationManager = jWTAuthenticationManager;
            this.accountRepository = accountRepository;
        }

        [HttpPost("Login")]
        public int Login(LoginVM login)
        {
            var user = accountRepository.Login(login.Username, login.Password);
            return user;
        }
    }
}
