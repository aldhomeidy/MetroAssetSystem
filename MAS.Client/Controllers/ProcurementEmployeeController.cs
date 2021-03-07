using MAS.Client.ViewModels;
using Metro_Asset_System.ViewModels;
using Microsoft.AspNetCore.Http;
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
    public class ProcurementEmployeeController : Controller
    {
        [HttpGet("master/request")]
        public ActionResult RequestData()
        {
            if (HttpContext.Session.GetInt32("Role") != 3) //belum login dan tidak ada hak akses
            {
                return RedirectToAction("Index", "Auth");
            }
            return View("~/Views/ProcurementEmployee/Request.cshtml");
        }

        [Route("employee/create/invoice")]
        [HttpPost]
        public HttpStatusCode CreateInvoice(CreateInvoiceVM createInvoiceVM)
        {
            createInvoiceVM.ProcurementEmployeeId = HttpContext.Session.GetString("Id");
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(createInvoiceVM), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Employee/Invoice", content).Result;
            return result.StatusCode;
        }

        [HttpGet("master/invoice")]
        public ActionResult InvoiceData()
        {
            if (HttpContext.Session.GetInt32("Role") != 3) //belum login dan tidak ada hak akses
            {
                return RedirectToAction("Index", "Auth");
            }
            return View("~/Views/ProcurementEmployee/Invoice.cshtml");
        }

        [Route("employee/return")]
        [HttpPost]
        public HttpStatusCode ReturnAsset(ReturnAssets returnAssets)
        {          
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(returnAssets), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Employee/Return", content).Result;
            return result.StatusCode;
        }

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

        [Route("procurementemployee/employee")]
        public ActionResult Employee()
        {
            return View("~/Views/ProcurementEmployee/Employee.cshtml");
        }

        [Route("procurementemployee/category")]
        public ActionResult Category()
        {
            return View("~/Views/ProcurementEmployee/Category.cshtml");
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


        [HttpGet]
        public String GetCategory(int Id)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44329/api/Category/" + Id).Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            return apiResponse.Result;
        }

        [HttpDelete]
        public HttpStatusCode DeleteCategory(int Id)
        {
            var httpClient = new HttpClient();
            var result = httpClient.DeleteAsync("https://localhost:44329/api/Category/" + Id).Result;
            return result.StatusCode;
        }

        [HttpPost]
        public HttpStatusCode CreateCategory(CategoryVM categoryVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(categoryVM), Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync("https://localhost:44329/api/Category/", content).Result;
            return result.StatusCode;
        }

        [HttpPut]
        public HttpStatusCode UpdateCategory(CategoryVM categoryVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(categoryVM), Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync("https://localhost:44329/api/Category/", content).Result;
            return result.StatusCode;
        }

        [HttpGet]
        public String GetEmployee(int Id)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44329/api/Employee/" + Id).Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            return apiResponse.Result;
        }

        [HttpPut]
        public HttpStatusCode UpdateEmployeeRole(UpdateEmployeeRoleVM updateEmployeeRoleVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(updateEmployeeRoleVM), Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync("https://localhost:44329/api/Employee/UpdateEmployeeRole", content).Result;
            return result.StatusCode;
        }

    }
}
