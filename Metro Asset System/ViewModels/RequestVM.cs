using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class RequestVM
    {
        public string RequesterId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string[] Assets { get; set; }
    }
}
