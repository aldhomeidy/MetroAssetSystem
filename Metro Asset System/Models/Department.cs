using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Models
{
    [Table("TB_M_Department")]
    public class Department
    {
        [Key, Required(ErrorMessage = "Tidak boleh kosong"), MaxLength(4, ErrorMessage = "Maksimal 4 karakter"), RegularExpression(@"^\d+$", ErrorMessage = "Harus berupa angka")]
        public string Id { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Maksimal 100 karakter")]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
