using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class PinaltyRepository : GeneralRepository<Pinalty, MyContext, int>
    {
        private readonly MyContext myContext;

        public PinaltyRepository(MyContext myContext) : base(myContext)
        {
            this.myContext = myContext;
        }

        public int Create(AssetVM assetVM) 
        {
            var pinalty = new Pinalty()
            {
                LowPinalty = assetVM.LowPinalty,
                MiddlePinalty = assetVM.MiddlePinalty,
                HighPinalty = assetVM.HighPinalty,
                LostPinalty = assetVM.LostPinalty,
                AssetId = assetVM.Id,
            };

            myContext.Add(pinalty);
            var resultPinalty = myContext.SaveChanges();

            if (resultPinalty == 1)
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
