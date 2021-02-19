using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_M_Employee")]
    public class Employee
    {
        [Key, Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(7, ErrorMessage = "Maksimal 7 karakter")]
        public string NIK { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(20, ErrorMessage = "Maksimal 20 karakter")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(50, ErrorMessage = "Maksimal 50 karakter")]
        public string LastName { get; set; }
        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Birthday { get; set; }
        [Required, RegularExpression(@"^08[0-9]{9,10}$", ErrorMessage = "Harus berupa angka diawali 08"), MaxLength(12, ErrorMessage = "Maksimal 12 karakter"), MinLength(11, ErrorMessage = "Minimal 11 karakter")]
        public string Phone { get; set; }
        [Required, EmailAddress(ErrorMessage ="Masukan format email yang valid"), MaxLength(100, ErrorMessage = "Maksimal 100 karakter")]
        public string Email { get; set; }
        [MaxLength(7, ErrorMessage = "Maksimal 7 karakter")]
        public string? ManagerId { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(4, ErrorMessage = "Maksimal 4 karakter")]
        public string DepartmentId { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public EmployeeRole Role { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual Department Department { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
    }

    public enum EmployeeRole 
    {
        [Display(Name = "Employee")]
        Employee = 0,
        [Display(Name = "Employee Manager")]
        Employee_Manager = 1,
        [Display(Name = "Procurement Manager")]
        Procurement_Manager = 2,
        [Display(Name = "Procurement Employee")]
        Procurement_Employee = 3
    }
    public enum Gender 
    { 
        [Display(Name ="Male")]
        Male = 0,
        [Display(Name = "Female")]
        Female =1
    }
}
