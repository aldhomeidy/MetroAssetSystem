using Metro_Asset_System.Context;
using Metro_Asset_System.Handler;
using Metro_Asset_System.Models;
using Metro_Asset_System.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class AssetRepository : GeneralRepository<Asset, MyContext, string>
    {
        private readonly Generator generator = new Generator();
        private readonly MyContext myContext;
        private readonly PinaltyRepository pinaltyRepository;

        public AssetRepository(MyContext myContext, PinaltyRepository pinaltyRepository) : base(myContext)
        {
            this.myContext = myContext;
            this.pinaltyRepository = pinaltyRepository;
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

        public int Create(AssetVM assetVM)
        {
            int max = 0;
            var yearNow = DateTime.Now.ToString("yy");
            var data = myContext.Assets.OrderByDescending(a => a.Id).Where(a => a.Id.Contains(yearNow)).Select(a => new { Id = a.Id }).FirstOrDefault();
            if (data != null)
            {
                max = Convert.ToInt32(data.Id.Substring(2, data.Id.Length - 2));//get max increment id in database          
            }
            string assetId = generator.GenerateAssetId(max);

            var asset = new Asset()
            {
                Id = assetId,
                Name = assetVM.Name,
                AssetStatus = StatusAsset.Fine,
                LoanStatus = StatusLoan.Available,
                InputDate = DateTime.Now.Date,
                CategoryId = assetVM.CategoryId
            };

            int max2 = 0;
            var data2 = myContext.Pinalties.OrderByDescending(p => p.Id).Select(p => new { Id = p.Id }).FirstOrDefault();
            if (data2 != null)
            {
                max2 = Convert.ToInt32(data2.Id);
            }
            int pinaltyId = generator.GenerateId(max2);

            var pinalty = new Pinalty()
            {
                LowPinalty = assetVM.LowPinalty,
                MiddlePinalty = assetVM.MiddlePinalty,
                HighPinalty = assetVM.HighPinalty,
                LostPinalty = assetVM.LostPinalty,
                AssetId = assetId
            };

            myContext.Add(asset);
            var resAsset = myContext.SaveChanges();

            var resPinalty = pinaltyRepository.Create(pinalty);

            if (resAsset > 0 && resPinalty > 0) 
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        public int Update(AssetVM assetVM) 
        {
            Asset asset = myContext.Assets.Where(a => a.Id == assetVM.Id).FirstOrDefault();
            if (assetVM.AssetStatus == "0") 
            {
                asset.AssetStatus = StatusAsset.Fine;
            } 
            else if (assetVM.AssetStatus == "1")
            {
                asset.AssetStatus = StatusAsset.Problem;
            } 
            else if (assetVM.AssetStatus == "2")
            {
                asset.AssetStatus = StatusAsset.Lost;
            }

            if (assetVM.LoanStatus == "0")
            {
                asset.LoanStatus = StatusLoan.Available;
            } 
            else if (assetVM.LoanStatus == "1")
            {
                asset.LoanStatus = StatusLoan.Unavailable;
            }
            asset.Name = assetVM.Name;
            myContext.Entry(asset).State = EntityState.Modified;

            var pinalty = myContext.Pinalties.Where(p => p.AssetId == assetVM.Id).FirstOrDefault();
            pinalty.LowPinalty = assetVM.LowPinalty;
            pinalty.MiddlePinalty = assetVM.MiddlePinalty;
            pinalty.HighPinalty = assetVM.HighPinalty;
            pinalty.LostPinalty = assetVM.LostPinalty;

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

        //public IEnumerable<Asset> GetAllAsset(AssetVM assetVM) 
        //{
        //    var data = myContext.Assets.Where(a => a.Id == assetVM.Id);
        //    return data;
        //}
    }
}
