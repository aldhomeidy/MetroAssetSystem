using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.ViewModels
{
    public class RegisterVM
    {        
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(20, ErrorMessage = "Maksimal 20 karakter")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(50, ErrorMessage = "Maksimal 50 karakter")]
        public string LastName { get; set; }
        [Required, DataType(DataType.Date)]
        public string Birthday { get; set; }
        [Required, RegularExpression(@"^08[0-9]{9,10}$", ErrorMessage = "Harus berupa angka diawali 08"), MaxLength(12, ErrorMessage = "Maksimal 12 karakter"), MinLength(11, ErrorMessage = "Minimal 11 karakter")]
        public string Phone { get; set; }
        [Required, EmailAddress(ErrorMessage = "Masukan format email yang valid"), MaxLength(100, ErrorMessage = "Maksimal 100 karakter")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(4, ErrorMessage = "Maksimal 4 karakter")]
        public string DepartmentId { get; set; }

        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(10, ErrorMessage = "Maksimal 10 karakter")]
        public string Username { get; set; }
    }
}
