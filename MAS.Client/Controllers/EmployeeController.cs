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
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            //condition check, will return different view with different roles
            if (HttpContext.Session.GetInt32("Role") == 0) //employee
            {                
                return View("~/Views/Requester/Index.cshtml");
            }
            else if (HttpContext.Session.GetInt32("Role") == 1)//emp manager
            {
                return View("~/Views/Requester/Index.cshtml");
            }
            else if (HttpContext.Session.GetInt32("Role") == 2)//proc manager
            {
                return View("~/Views/Requester/Index.cshtml");
            }
            else if (HttpContext.Session.GetInt32("Role") == 3)//proc emp
            {
                return View("~/Views/Requester/Index.cshtml");
            }
            else //belum login
            {
                return RedirectToAction("Index","Auth");
            }
            
        }

        public new ActionResult Request()
        {
            if(HttpContext.Session.GetInt32("Role") != 0 ) //belum login dan tidak ada hak akses
            {
                return RedirectToAction("Index", "Auth");
            }
            return View("~/Views/Requester/Request.cshtml");
        }

        [Route("employee/create")]
        [HttpPost]
        public HttpStatusCode CreateRequest(RequestVM requestVM)
        {
            requestVM.RequesterId = HttpContext.Session.GetString("Id");
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(requestVM), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Employee/Request", content).Result;
            return result.StatusCode;            
        }

        //Aldho
        [Route("employee/add/request")]
        public ActionResult AddRequest() 
        {
            if (HttpContext.Session.GetInt32("Role") != 0) //belum login dan tidak ada hak akses
            {
                return RedirectToAction("Index", "Auth");
            }
            return View("~/Views/Requester/CreateRequest.cshtml");
        }        

        // Edward
        // [Route("employee/invoice")]
        // public ActionResult Invoice()
        // {
        //     return View("~/Views/Requester/Invoice.cshtml");
        // }

        // [Route("employee/add/request")]
        // public ActionResult AddRequest() 
        // {
        //     return View("~/Views/Auth/MyProfile.cshtml");
        // }
    }
}
