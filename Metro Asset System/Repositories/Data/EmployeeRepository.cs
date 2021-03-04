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

        public int UpdateEmployeeRole(UpdateEmployeeRoleVM updateEmployeeRoleVM) 
        {
            var employee = myContext.Employees.Where(e => e.NIK == updateEmployeeRoleVM.NIK).FirstOrDefault();
            if (updateEmployeeRoleVM.Role == "0") 
            {
                employee.Role = EmployeeRole.Employee;
            }
            else if (updateEmployeeRoleVM.Role == "1")
            {
                employee.Role = EmployeeRole.Employee_Manager;
            }
            else if (updateEmployeeRoleVM.Role == "2")
            {
                employee.Role = EmployeeRole.Procurement_Manager;
            }
            else if (updateEmployeeRoleVM.Role == "3")
            {
                employee.Role = EmployeeRole.Procurement_Employee;
            }

            myContext.Entry(employee).State = EntityState.Modified;
            var result = myContext.SaveChanges();

            if (result > 0)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
