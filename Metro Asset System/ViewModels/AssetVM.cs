using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class AssetVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string AssetStatus { get; set; }
        public string LoanStatus { get; set; }
    }
}
