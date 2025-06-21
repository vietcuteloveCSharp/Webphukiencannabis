using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;
using static Enum.EnumableClass.EnumableClass;

namespace DAL.Entities
{
    [Table("Spectrums",Schema = "Inventory")]   
    public class Spectrum
    {
        [Key]
        public int SpectrumId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public ESpectrumType Type { get; set; } 
        public string Description { get; set; }
        public virtual ICollection<GrowLight> GrowLights { get; set; }
    }
}
