using MAS.Client.ViewModels;
using Metro_Asset_System.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Client.Controllers
{
    public class ProcurementEmployee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("procurementemployee/assets")]   
        public ActionResult Assets()
        {
            return View("~/Views/ProcurementEmployee/Assets.cshtml");
        }

        public ActionResult CreateAsset() 
        {
            return View();
        }

        [Route("procurementemployee/request")]
        public new ActionResult Request()
        {
            return View("~/Views/ProcurementEmployee/Request.cshtml");
        }

        [Route("procurementemployee/invoice")]
        public ActionResult Invoice()
        {
            return View("~/Views/ProcurementEmployee/Invoice.cshtml");
        }

        [Route("procurementemployee/requester")]
        public ActionResult Requester() 
        {
            return View("~/Views/ProcurementEmployee/Requester.cshtml");
        }

        [Route("procurementemployee/department")]
        public ActionResult Department()
        {
            return View("~/Views/ProcurementEmployee/Department.cshtml");
        }

        [HttpPost]
        public HttpStatusCode SubmitAsset(AssetVM assetVM) 
        { 
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(assetVM), Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync("https://localhost:44329/api/Asset/SubmitAsset/", content).Result;
            return result.StatusCode;
        }

        [HttpGet]
        public String Get(int Id)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44329/api/Asset/" + Id).Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            return apiResponse.Result;
        }

        [HttpPut]
        public HttpStatusCode Update(AssetVM assetVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(assetVM), Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync("https://localhost:44329/api/Asset/UpdateAsset", content).Result;
            return result.StatusCode;
        }

        [HttpDelete]
        public HttpStatusCode DeleteAsset(int Id)
        {
            var httpClient = new HttpClient();
            var result = httpClient.DeleteAsync("https://localhost:44329/api/Asset/" + Id).Result;
            return result.StatusCode;
        }

        [HttpDelete]
        public HttpStatusCode DeleteDepartment(int Id)
        {
            var httpClient = new HttpClient();
            var result = httpClient.DeleteAsync("https://localhost:44329/api/Department/" + Id).Result;
            return result.StatusCode;
        }


        [HttpPost]
        public HttpStatusCode CreateDepartment(DepartmentVM departmentVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(departmentVM), Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync("https://localhost:44329/api/Department/SubmitDepartment/", content).Result;
            return result.StatusCode;
        }

        [HttpGet]
        public String GetDepartment(int Id)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44329/api/Department/" + Id).Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            return apiResponse.Result;
        }

        [HttpPut]
        public HttpStatusCode UpdateDepartment(DepartmentVM departmentVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(departmentVM), Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync("https://localhost:44329/api/Department/UpdateDepartment", content).Result;
            return result.StatusCode;
        }
    }
}
