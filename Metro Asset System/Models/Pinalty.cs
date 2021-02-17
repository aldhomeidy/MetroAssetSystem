using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_M_Pinalty")]
    public class Pinalty
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public long LowPinalty { get; set; }
        [Required]
        public long MiddlePinalty { get; set; }
        [Required]
        public long HighPinalty { get; set; }
        [Required]
        public long LostPinalty { get; set; }
        [ForeignKey("Asset"), Required, MaxLength(7, ErrorMessage = "Maksimal 10 karakter")]
        public string AssetId { get; set; }
        public virtual Asset Asset { get; set; }

    }
}
