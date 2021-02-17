using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class EmployeeRepository : GeneralRepository<Employee, MyContext, string>
    {       
        private readonly MyContext myContext;
        private readonly DbSet<Employee> employees;

        public EmployeeRepository(MyContext myContext) : base(myContext)
        {
            this.myContext = myContext;
            myContext.Set<Employee>();
            employees = myContext.Set<Employee>();
        }
    }
}
