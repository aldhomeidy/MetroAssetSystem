using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_M_RequestDetail")]
    public class RequestDetail
    {
        [Key, Required(ErrorMessage = "Tidak boleh kosong")]
        public int Id { get; set; }
        [Required]
        public StatusRequestDetail Status { get; set; }
        [MaxLength(20,ErrorMessage ="Maksimal 20 karakter")]
        public string? Note { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public string Date { get; set; }
        //[Required]
        [ MaxLength(10,ErrorMessage ="Maksimal berisi 10 karakter")]
        public string RequestId { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(7, ErrorMessage = "Maksimal berisi 11 karakter")]
        public string EmployeeId { get; set; }


        public virtual Employee Employee { get; set; }
        public virtual Request Request { get; set; }
    }

    public enum StatusRequestDetail 
    {
        [Display(Name = "Not Set")]
        NotSet = 0,
        [Display(Name = "Accepted")]
        Accepted = 1,
        [Display(Name = "Rejected")]
        Rejected = 2
    }
}
