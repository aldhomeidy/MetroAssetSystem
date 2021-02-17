using Metro_Asset_System.Context;
using Metro_Asset_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Repositories.Data
{
    public class RequestDetailRepository : GeneralRepository<RequestDetail, MyContext, int>
    {
        public RequestDetailRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
