using Metro_Asset_System.Base.Controller;
using Metro_Asset_System.Models;
using Metro_Asset_System.Repositories.Data;
using Metro_Asset_System.ViewModels;
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
        private readonly PinaltyRepository pinaltyRepository;

        public AssetController(AssetRepository assetRepository, PinaltyRepository pinaltyRepository):base(assetRepository)
        {
            this.assetRepository = assetRepository;
            this.pinaltyRepository = pinaltyRepository;
        }

        [HttpGet("GetAsset/{status}")]
        public ActionResult GetAsset(string available)
        {
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

        [HttpPut("UpdateAsset")]
        public ActionResult UpdateAsset(AssetVM assetVM)
        {
            var data = assetRepository.Update(assetVM);
            if (data == 1)
            {
                return Ok(new { status = "Update Success" });
            }
            else
            {
                return StatusCode(500, new { status = "Internal Server Error" });
            }
        }

        [HttpPost("SubmitAsset")]
        public ActionResult SubmitAsset(AssetVM assetVM)
        {
            var data = assetRepository.Create(assetVM);
            if (data == 1)
            {
                return Ok(new { status = "Submit Success" });
            }
            else
            {
                return StatusCode(500, new { status = "Internal Server Error" });
            }
        }

        //[HttpGet("GetAllAsset")]
        //public ActionResult
    }
}
