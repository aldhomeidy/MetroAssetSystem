using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class AssetRepository : GeneralRepository<Asset, MyContext, string>
    {
        private readonly MyContext myContext;
        public AssetRepository(MyContext myContext) : base(myContext)
        {
            this.myContext = myContext;
        }

        public int UpdateStatus(string id, bool available) 
        {
            var data = myContext.Assets.FirstOrDefault(x => x.Id == id);
            if (available)
            {
                data.LoanStatus = StatusLoan.Available;
            }
            else {
                data.LoanStatus = StatusLoan.Unavailable;
            }
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
