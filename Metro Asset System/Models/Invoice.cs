using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_T_Invoice")]
    public class Invoice
    {
        [Key, Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(8, ErrorMessage = "Maksimal 8 karakter")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong")]
        public StatusInvoice Status {get; set; } 
        [Required,DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime InvoiceDate { get; set; }
        //[Required]
        [MaxLength(10)]
        public string RequestId {get; set; }
        [Required,MaxLength(7)]
        public string ProcurementEmployeeId { get; set; }
        public virtual Request Request { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual PinaltyHistory PinaltyHistory { get; set; }
    }

    public enum StatusInvoice 
    {
        [Display(Name = "On Going")]
        On_Going =0,
        [Display(Name = "Finished Fine")]
        Finished_Fine = 1,
        [Display(Name = "Finished With Problem")]
        Finished_With_Problem = 2
    }
}
