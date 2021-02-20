using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class SetPinaltyVM
    {
        public string InvoiceId { get; set; }
        public string[] AssetId { get; set; }
        public string[] Condition { get; set; }
    }
}
