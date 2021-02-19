using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class ManageRequestVM
    {
        [Required]
        public string RequestId { get; set; }
        [Required]
        public string RequestDetailStatus { get; set; }

        public string Status { get; set; }
        [Required]
        public string Note { get; set; }
        [Required]
        public string EmployeeId { get; set; }
    }
}
