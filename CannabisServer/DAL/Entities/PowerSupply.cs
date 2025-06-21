using Enum;
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
    [Table("PowerSupplies", Schema = "lighting")]
    public class PowerSupply
    {
        [Key]
        public int PowerSupplyId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public EPowerSypplyType Type { get; set; } 
        public int Voltage { get; set; } 
        public virtual ICollection<GrowLight> GrowLights { get; set; }
    }
}
