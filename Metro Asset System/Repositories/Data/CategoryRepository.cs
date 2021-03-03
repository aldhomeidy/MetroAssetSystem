using Metro_Asset_System.Context;
using Metro_Asset_System.Handler;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class CategoryRepository : GeneralRepository<Category, MyContext, int>
    {
        private readonly Generator generator = new Generator();
        private readonly MyContext myContext;

        public CategoryRepository(MyContext myContext) : base(myContext) 
        {
            this.myContext = myContext;
        }

        public int Create(CategoryVM categoryVM) 
        {
            int max = 0;
            var data = myContext.Categories.OrderByDescending(c => c.Id).Select(c => new { Id = c.Id }).FirstOrDefault();
            
            if (data != null)
            {
                max = Convert.ToInt32(data.Id);
            }
            int categoryId = generator.GenerateId(max);

            var category = new Category()
            {
                Id = categoryId,
                Name = categoryVM.Name,
            };

            myContext.Add(category);

            var resultCategory = myContext.SaveChanges();

            if (resultCategory == 1) 
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
