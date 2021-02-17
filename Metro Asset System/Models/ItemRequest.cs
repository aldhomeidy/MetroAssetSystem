using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_T_ItemRequest")]
    public class ItemRequest
    {
        [Key, Required(ErrorMessage = "Tidak boleh kosong")]
        public int Id { get; set; }
        [ForeignKey("Request"), Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(10, ErrorMessage = "Maksimal 10 karakter")]
        public string RequestId { get; set; }
        [ForeignKey("Asset"), Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(7, ErrorMessage = "Maksimal 10 karakter")]
        public string AssetId { get; set; }
        
        public virtual Request Request { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
