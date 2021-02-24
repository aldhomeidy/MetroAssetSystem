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
            //var httpClient = new HttpClient();
            //var response = httpClient.GetAsync("https://localhost:44329/api/Department").Result;            
            //var apiResponse = response.Content.ReadAsStringAsync();
            //string json = @"[ { 'Id': 1, 'Name': 'Customer'}, { 'Id': 2, 'Name':'Admin'} ]";
            //roleList = JsonConvert.DeserializeObject<List<RoleVM>>(apiResponse);
            //apiResponse.Result;
            //var departmentList = JsonConvert.DeserializeObject<List<Department>>(apiResponse.Result);
            Department department = new Department
            {
                Id = "212",
                Name = "ADD 1"
            };          
            ViewData["Department"] = department;
            return View();
        }

        [HttpPost]
        public HttpStatusCode Login(LoginVM loginVM) 
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Account/Login", content).Result;
           /* if (result.StatusCode == HttpStatusCode.OK)
            {
                HttpContext.Session.SetString("Id", "The Doctor");
            }*/
            return result.StatusCode;


            /* var httpClient = new HttpClient();
             StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");

             var result = httpClient.PostAsync("https://localhost:44329/api/Account/Login", content).Result;
             var data = result.Content.ReadAsStringAsync().Result;
             var dataa = JsonConvert.DeserializeObject(data);
             return dataa;*/

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

       /* [HttpPost("/{field}")]
        public HttpStatusCode Check(string field,RegisterVM registerVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerVM), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Account/Check/"+ field, content).Result;
            return result.StatusCode;
        }*/

        public string Dashboard() 
        {
            return "ok";
        }
    }    
}
