using Metro_Asset_System.Base.Controller;
using Metro_Asset_System.Models;
using Metro_Asset_System.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Controllers
{
    public class AssetController : BaseController<Asset, AssetRepository, string>
    {
        private readonly AssetRepository assetRepository;
        public AssetController(AssetRepository assetRepository):base(assetRepository)
        {
            this.assetRepository = assetRepository;
        }

        [HttpGet("GetAsset/{condition}")]
        public ActionResult GetAsset(string condition)
        {
            var available=false;
            if (condition == "available") {
                available = true;
            }
                
            var data = assetRepository.GetByConditon(available);
            if (data!=null)
            {
                return Ok(new {data=data, status = "Ok" });
            }
            else
            {
                return StatusCode(500, new {data=data, status = "Internal server error" });
            }
        }
    }
}
