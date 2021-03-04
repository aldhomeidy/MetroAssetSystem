using Metro_Asset_System.Base.Controller;
using Metro_Asset_System.Models;
using Metro_Asset_System.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metro_Asset_System.ViewModels;

namespace Metro_Asset_System.Controllers
{
    public class RequestController : BaseController<Request, RequestRepository, string>
    {
        private readonly RequestRepository requestRepository;
        public RequestController(RequestRepository requestRepository):base(requestRepository)
        {
            this.requestRepository = requestRepository;
        }

        [HttpPost("GetRequest")]
        public ActionResult GetRequest(HistoryRequest historyRequest)//for requester and procurement employee
        {
            var requesterId = historyRequest.RequesterId;
            var data = requestRepository.GetByConditon(historyRequest.Condition,requesterId);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return StatusCode(500, data);
            }
        }

        [HttpPost("GetRequestData")]
        public ActionResult GetRequestData(HistoryRequest historyRequest) //for manager
        {
            var requesterId = historyRequest.RequesterId;
            var data = requestRepository.GetByConditionManager(historyRequest.Level,historyRequest.Condition, requesterId);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return StatusCode(500, data);
            }
        }
    }
}
