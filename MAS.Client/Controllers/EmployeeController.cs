using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAS.Client.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            //condition check, will return different view with different roles

            //requester
            return View("~/Views/Requester/Index.cshtml");
        }

        public new ActionResult Request()
        {
            return View("~/Views/Requester/Request.cshtml");
        }

        [Route("employee/add/request")]
        public ActionResult AddRequest() 
        {
            return View("~/Views/Requester/CreateRequest.cshtml");
        }

        [Route("employee/profile")]
        public ActionResult Profile() 
        {
            return View("~/Views/Auth/MyProfile.cshtml");
        }
    }
}
