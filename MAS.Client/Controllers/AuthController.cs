using MAS.Client.ViewModels;
using Metro_Asset_System.Models;
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
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Id")!=null)
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }        

        [HttpPost]
        public HttpStatusCode Login(LoginVM loginVM) 
        {                  
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Account/Login", content).Result;
            var data = result.Content.ReadAsStringAsync().Result;
            var dataJson = JsonConvert.DeserializeObject<LoginResult>(data);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                HttpContext.Session.SetString("Id", dataJson.NIk);
                HttpContext.Session.SetString("Name", dataJson.FirstName);
                HttpContext.Session.SetInt32("Role", dataJson.Role);
            }

            return result.StatusCode;

        }

        [HttpPost]
        public HttpStatusCode Register(RegisterVM registerVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerVM), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Account/Register", content).Result;
            return result.StatusCode;
        }

        [HttpPost]
        public HttpStatusCode Forget(RegisterVM registerVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerVM), Encoding.UTF8, "application/json");

            var result = httpClient.PutAsync("https://localhost:44329/api/Account/ForgotPassword", content).Result;
            return result.StatusCode;
        }

       
        public ActionResult Verify(string id) {
            var httpClient = new HttpClient();
            var result = httpClient.GetAsync("https://localhost:44329/api/account/verify/"+id).Result;

            if (result.StatusCode == HttpStatusCode.OK)
            {
                ViewBag.Result = 200;
            }
            else {
                ViewBag.Result = 404;
            }            
            return View("~/Views/Auth/EmailConfirmed.cshtml");           
        }

       /* [HttpPost("/{field}")]
        public HttpStatusCode Check(string field,RegisterVM registerVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerVM), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Account/Check/"+ field, content).Result;
            return result.StatusCode;
        }*/
        
        public ActionResult Logout() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public ActionResult Profile()
        {
            if (HttpContext.Session.GetInt32("Role") == 0)
            {
                return View("~/Views/Requester/MyProfile.cshtml");
            }
            else if(HttpContext.Session.GetInt32("Role") == 1)
            {
                return View("~/Views/RequesterManager/MyProfile.cshtml");
            }
            else if (HttpContext.Session.GetInt32("Role") == 2)
            {
                return View("~/Views/ProcurementManager/MyProfile.cshtml");
            }
            else if (HttpContext.Session.GetInt32("Role") == 3)
            {
                return View("~/Views/ProcurementEmployee/MyProfile.cshtml");
            }
            else
            {
                /*var httpClient = new HttpClient();
                StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");

                var result = httpClient.PostAsync("https://localhost:44329/api/Account/Login", content).Result;
                var data = result.Content.ReadAsStringAsync().Result;
                var dataJson = JsonConvert.DeserializeObject<LoginResult>(data);*/

                return View("~/Views/ProcurementManager/MyProfile.cshtml");
                //return RedirectToAction("Index", "Employee");
            }
        }
    }    
}
