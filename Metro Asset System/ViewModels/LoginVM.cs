using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(10, ErrorMessage = "Maksimal 10 karakter")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong")]
        public string Username { get; set; }
        public string NIK { get; set; }

    }
}
