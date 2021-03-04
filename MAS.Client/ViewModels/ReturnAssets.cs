using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAS.Client.ViewModels
{
    public class ReturnAssets
    {
        public string InvoiceId { get; set; }
        public string StatusInvoice { get; set; }
        public List<string>[] Assets { get; set; }
    }
}
