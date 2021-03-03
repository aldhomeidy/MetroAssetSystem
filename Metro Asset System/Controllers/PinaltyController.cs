using Metro_Asset_System.Base.Controller;
using Metro_Asset_System.Models;
using Metro_Asset_System.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PinaltyController : BaseController<Pinalty, PinaltyRepository, int>
    {
        private readonly PinaltyRepository pinaltyRepository;

        public PinaltyController(PinaltyRepository pinaltyRepository) : base (pinaltyRepository)
        {
            this.pinaltyRepository = pinaltyRepository;
        }
    }
}
