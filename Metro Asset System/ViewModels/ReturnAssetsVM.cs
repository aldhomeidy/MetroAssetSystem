using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class ReturnAssetsVM
    {
        public string InvoiceId { get; set; }        
        public string StatusInvoice { get; set; }
        public string[,] Assets { get; set; }
        //index 0 berisi id asset, 1 berisi kondisi aset
        //kondisi aset
        //0->fine
        //1->low damaged
        //2->middle damaged
        //3->high damaged
        //4->lost
    }
}
