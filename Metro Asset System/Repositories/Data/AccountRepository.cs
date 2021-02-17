using Dapper;
using Metro_Asset_System.Context;
using Metro_Asset_System.Handler;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class AccountRepository : GeneralRepository<Account, MyContext, string>
    {
        private readonly MyContext myContext;
        private readonly SendEmail sendEmail = new SendEmail();
        private readonly Generator generator = new Generator();
        private readonly EmployeeRepository employeeRepository;
        public IConfiguration Configuration { get; }

        public AccountRepository(MyContext myContext, EmployeeRepository employeeRepository, IConfiguration configuration) : base(myContext)
        {
            myContext.Set<Account>();
            this.myContext = myContext;
            this.employeeRepository = employeeRepository;
            this.Configuration = configuration;
        }

        public string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt(12);            
            return BCrypt.Net.BCrypt.HashPassword(password,salt);
        }

        public int Register(RegisterVM registerVM)
        {
            var nik = generator.RandomNumber(1000000,9999999);
            var verifyUrl = "https://localhost:44329/api/account/verifiy/"+nik;
            var subject = "Email Confirmation";
            var email = registerVM.Email;
            var message = "<h3>Hello " + registerVM.FirstName + ", </h3>";
                message += "<br><p>Your MetroAssets Account has been created. But you must to activate your account first by confirmation your registered email.</p>";
                message += "<br><p>Just click link down bellow : </p>";
                message += "<br><br>";
                message += "<a href="+verifyUrl+">"+verifyUrl+"<a/>";


            //set email requerement
            var data = new[] { email, subject, message };

            var employee = new Employee()
            {
                NIK = nik,
                FirstName = registerVM.FirstName,
                LastName = registerVM.LastName,
                Email = registerVM.Email,
                Phone = registerVM.Phone,
                Birthday = registerVM.Birthday,
                DepartmentId = registerVM.DepartmentId,
                Role = EmployeeRole.Employee
            };

            var account = new Account()
            {
                NIK = employee.NIK,
                Username =registerVM.Username,
                Password = this.HashPassword("B0o7c@mp"),
                Status = StatusAccount.Restricted
            };

            var resPerson = employeeRepository.Create(employee);

            myContext.Add(account);

            var resAccount = myContext.SaveChanges();

            if (resAccount > 0 && resPerson > 0)
            {
                sendEmail.Send(data);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        public int Login(string username, string password)
        {
            var data = myContext.Accounts.Where(a => a.Username == username).FirstOrDefault();
            if (data != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, data.Password))
                {
                    if (data.Status == StatusAccount.Active)
                    {
                        return 1;//valid        
                    }
                    else {
                        return 2;//email belum aktif        
                    }
                }
                else {
                    return 3;//password salah
                }
            }
            else {
                return 4;//username belum terdaftar
            }
        }
        public int Verificate(string nik) 
        {
            var data = myContext.Accounts.FirstOrDefault(x => x.NIK == nik);
            data.Status = StatusAccount.Active;
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
