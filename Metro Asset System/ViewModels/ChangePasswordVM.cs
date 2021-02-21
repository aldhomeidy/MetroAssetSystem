﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class ChangePasswordVM
    {
        [Required]
        public string NIK{ get; set; }
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Compare("NewPassword"), Required]
        public string ConfirmPassword { get; set; }
    }
}
