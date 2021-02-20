using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class PinaltyHistoryRepository : GeneralRepository<PinaltyHistory, MyContext, int>
    {
        private readonly MyContext myContext;
        public IConfiguration Configuration { get; }

        public PinaltyHistoryRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            myContext.Set<PinaltyHistory>();
            this.myContext = myContext;
            this.Configuration = configuration;
        }

        public int SetPinalty(SetPinaltyVM setPinaltyVM) 
        {
            //PinaltyHistory pinaltyHistory = myContext.PinaltyHistories.Where(ph => ph.InvoiceId == setPinaltyVM.InvoiceId).FirstOrDefault();
            long pinalty = 0;
            var pinaltyHistory = new PinaltyHistory() 
            { 
                InvoiceId = setPinaltyVM.InvoiceId,
                Pinalty = pinalty,
            };

            myContext.Add(pinaltyHistory);

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
