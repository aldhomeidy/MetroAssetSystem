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

        public IEnumerable<Asset> GetByConditon(bool available) 
        {           
            if (available) 
            { 
                var data = myContext.Assets.Where(a => a.LoanStatus == StatusLoan.Available);
                return data;
            }
            else 
            {
                var data = myContext.Assets.Where(a => a.LoanStatus == StatusLoan.Unavailable);
                return data;
            }
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

        public int UpdateAssetCondition(string id, string condition) 
        {
            var data = myContext.Assets.FirstOrDefault(x => x.Id == id);
            if (condition == "0")
            {
                data.AssetStatus = StatusAsset.Fine;
            }
            else if (condition == "1")
            {
                data.AssetStatus = StatusAsset.Problem;
            }
            else {
                data.AssetStatus = StatusAsset.Lost;
            }
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
