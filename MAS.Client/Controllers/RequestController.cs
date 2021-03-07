using MAS.Client.ViewModels;
using Metro_Asset_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Client.Controllers
{
    public class RequestController : Controller
    {
        [HttpGet("Request/{condition}")]
        public List<Request> GetRequest(string condition)//for employee
        {
            var requestData = new RequestHistory()
            {
                Condition = condition,
                RequesterId = HttpContext.Session.GetString("Id")
                //RequesterId = "1159208"
            };          
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Request/GetRequest", content).Result;
            var data = result.Content.ReadAsStringAsync().Result;
            var dataJson = JsonConvert.DeserializeObject<List<Request>>(data);

            return dataJson;
        }


        [HttpGet("Request/data/{condition}")]
        public List<Request> GetDataRequest(string condition)//for procurement employee
        {
            var requestData = new RequestHistory()
            {
                Condition = condition                
            };
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Request/GetRequest", content).Result;
            var data = result.Content.ReadAsStringAsync().Result;
            var dataJson = JsonConvert.DeserializeObject<List<Request>>(data);

            return dataJson;
        }

        [HttpGet("Request/manager/{level}/{condition}")]
        public List<Request> GetRequestData(string level, string condition)//for manager
        {
            var requestData = new RequestHistory()
            {
                Condition = condition,
                RequesterId = HttpContext.Session.GetString("Id"),
                Level = level
            };
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

            var result = httpClient.PostAsync("https://localhost:44329/api/Request/GetRequestData", content).Result;
            var data = result.Content.ReadAsStringAsync().Result;
            var dataJson = JsonConvert.DeserializeObject<List<Request>>(data);

            return dataJson;
        }
    }
}
