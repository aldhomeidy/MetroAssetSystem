using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_M_Asset")]
    public class Asset
    {
        [Key, Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(7, ErrorMessage = "Maksimal 7 karakter"), RegularExpression(@"^\d+$", ErrorMessage = "Harus berupa angka")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(50, ErrorMessage = "Maksimal 50 karakter"), RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Harus berupa huruf")]
        public string Name { get; set; }
        [Required]
        public StatusAsset AssetStatus { get; set; }
        public StatusLoan LoanStatus { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public string InputDate { get; set; }
        [ForeignKey("Category"),Required(ErrorMessage = "Tidak boleh kosong")]
        public int CategoryId { get; set; }

        public virtual Pinalty Pinalty { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ItemRequest> ItemRequest { get; set; }
    }

    public enum StatusAsset 
    {
        [Display(Name = "Fine")]
        Fine = 0,
        [Display(Name = "Problem")]
        Problem = 1,
        [Display(Name = "Lost")]
        Lost = 2
    }

    public enum StatusLoan 
    {
        [Display(Name = "Available")]
        Available = 0,
        [Display(Name = "Unavailable")]
        Unavailable = 1
    }
}
