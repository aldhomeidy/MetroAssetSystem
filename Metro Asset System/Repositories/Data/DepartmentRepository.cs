using MAS.Client.ViewModels;
using Metro_Asset_System.Context;
using Metro_Asset_System.Handler;
using Metro_Asset_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class DepartmentRepository : GeneralRepository<Department, MyContext, string>
    {
        private readonly Generator generator = new Generator();
        private readonly MyContext myContext;

        public DepartmentRepository(MyContext myContext) : base(myContext)
        {
            this.myContext = myContext;
        }

        public int Create(DepartmentVM departmentVM)
        {
            int max = 0;
            var yearNow = DateTime.Now.ToString("yy");
            var data = myContext.Departments.OrderByDescending(d => d.Id).Where(d => d.Id.Contains(yearNow)).Select(d => new { Id = d.Id }).FirstOrDefault();
            if (data != null)
            {
                max = Convert.ToInt32(data.Id.Substring(2, data.Id.Length - 2));//get max increment id in database          
            }
            string departmentId = generator.GenerateDepartmentId(max);

            var department = new Department()
            {
                Id = departmentId,
                Name = departmentVM.Name,
            };

            myContext.Add(department);
            var resultDepartment = myContext.SaveChanges();

            if (resultDepartment == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Update(DepartmentVM departmentVM) 
        {
            Department department = myContext.Departments.Where(d => d.Id == departmentVM.Id).FirstOrDefault();

            department.Name = departmentVM.Name;

            myContext.Entry(department).State = EntityState.Modified;

            var resultUpdate = myContext.SaveChanges();

            if (resultUpdate > 0)
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
