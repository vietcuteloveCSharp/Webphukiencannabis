using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.EnumableClass.EnumableClass;

namespace DAL.Entities
{
    [Table("CoolingSystems",Schema = "Inventory")]
    public class CoolingSystem
    {
        [Key]
        public int CoolingSystemId { get; set; }
        [Required(ErrorMessage ="Type is required.")]
        [Column(TypeName = "nvarchar(20)")]
        public ECoolingType Type { get; set; } 
        public string Description { get; set; }
        public virtual ICollection<GrowLight> GrowLights { get; set; }
    }
}
