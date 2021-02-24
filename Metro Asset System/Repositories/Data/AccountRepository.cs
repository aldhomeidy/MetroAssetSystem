using Dapper;
using Metro_Asset_System.Context;
using Metro_Asset_System.Content;
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
        private readonly AuthContent authContent = new AuthContent();
        private readonly Generator generator = new Generator();
        private readonly BCryptConfigure bCryptConfigure = new BCryptConfigure();
        private readonly EmployeeRepository employeeRepository;      

        public AccountRepository(MyContext myContext, EmployeeRepository employeeRepository) : base(myContext)
        {
            myContext.Set<Account>();
            this.myContext = myContext;
            this.employeeRepository = employeeRepository;            
        }

       /* public int CheckAccountUniqueField(string field, string value) 
        {
            if (field == "username")
            {
                var data = myContext.Accounts.Include(a => a.Employee).Where(a => a.Username == value).FirstOrDefault();
                if (data != null)
                {
                    return 1;
                }
            }
            else if (field == "phone")
            {
                var data = myContext.Accounts.Include(a => a.Employee).Where(a => a.Employee.Phone == value).FirstOrDefault();
                if (data != null)
                {
                    return 1;
                }
            }
            else 
            {
                var data = myContext.Accounts.Include(a => a.Employee).Where(a => a.Employee.Email == value).FirstOrDefault();
                if (data != null)
                {
                    return 1;
                }
            }
            return 0;
        }*/
        public int Register(RegisterVM registerVM)
        {
            var nik = generator.RandomNumber(1000000,9999999);
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
                Password = bCryptConfigure.HashPassword("B0o7c@mp"),
                Status = StatusAccount.Restricted
            };

            var resPerson = employeeRepository.Create(employee);

            myContext.Add(account);

            var resAccount = myContext.SaveChanges();

            //set email data requirement
            var data = new[] { nik, registerVM.Email, registerVM.FirstName };
            if (resAccount > 0 && resPerson > 0)
            {
                authContent.Register(data);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        public int Login(string username, string password)
        {
            var data = myContext.Accounts.Where(a => a.Username == username).Select(a => new { NIK = a.NIK, Password = a.Password, Status = a.Status }).FirstOrDefault();
            if (data != null)
            {
                if (bCryptConfigure.Verify(password, data.Password))
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

        public int ChangePassword(string NIK, string password)
        {
            Account acccount = myContext.Accounts.Where(a => a.NIK == NIK).FirstOrDefault();
            acccount.Password =bCryptConfigure.HashPassword(password);
            myContext.Entry(acccount).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            return result;
        }

        public int ForgotPassword(string email)
        {

            Account account = myContext.Accounts.Include(a=>a.Employee).Where(e => e.Employee.Email == email).FirstOrDefault();
            if (account == null) {
                return 2;//email tidak terdaftar
            }
            
            string newPassword = Guid.NewGuid().ToString();

            account.Password = bCryptConfigure.HashPassword(newPassword);
            myContext.Entry(account).State = EntityState.Modified;
            var result = myContext.SaveChanges();

            if (result > 0)
            {
                //set email requirement
                var data = new[] { email, account.Employee.FirstName, newPassword };
                authContent.ForgetPassword(data);
                return 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
