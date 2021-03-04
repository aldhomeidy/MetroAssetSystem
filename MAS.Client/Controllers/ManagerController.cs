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
    public class ManagerController : Controller
    {
        public ActionResult Approval()
        {
            if (HttpContext.Session.GetInt32("Role") == 1)//manager level 1
            {
                return View("~/Views/RequesterManager/Approval.cshtml");
            }
            else if (HttpContext.Session.GetInt32("Role") == 2)
            {//manager level 2
                return View("~/Views/ProcurementManager/Approval.cshtml");
            }
            else {//belum login
                return RedirectToAction("Index","Auth");
            }
        }

        [Route("manager/approving")]
        [HttpPost]
        public HttpStatusCode CreateRequest(ManageRequestVM manageRequestVM)
        {
            manageRequestVM.EmployeeId = HttpContext.Session.GetString("Id");
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(manageRequestVM), Encoding.UTF8, "application/json");

            var result = httpClient.PutAsync("https://localhost:44329/api/Employee/ManageRequest", content).Result;
            return result.StatusCode;            
        }
    }
}
