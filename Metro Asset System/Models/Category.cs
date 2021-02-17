using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_M_Category")]
    public class Category
    {
        [Key, Required(ErrorMessage = "Tidak boleh kosong"), RegularExpression(@"^\d+$", ErrorMessage = "Harus berupa angka")]
        public int Id { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Harus berupa huruf"), MaxLength(30, ErrorMessage ="Maksimal 30 karakter")]
        public string Name { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
    }
}
