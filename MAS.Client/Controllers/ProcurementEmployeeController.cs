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

    }
}
