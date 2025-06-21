using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Dehumidifiers", Schema = "Inventory")]
    public class Dehumidifier
    {
        [Key]
        public int DehumidifierId { get; set; }
        [Required(ErrorMessage = "Dehumidifier name is required.")]
        [StringLength(100,ErrorMessage = "Dehumidifier name no more than 100 characters.")]
        public string DehumidifierName { get; set; }
        [Column(TypeName ="decimal(3,2")] 
        
        public decimal DehumidificationCapacity { get; set; } // Capacity in liters/day or similar
        public int Quantity { get; set; }
        [Required(ErrorMessage ="Id brand is required.")]
        public int BrandId { get; set; } // Foreign Key
        [Column(TypeName = "decimal(10,2")]
        public decimal CoverageArea { get; set; } // In square meters or feet
        [Column(TypeName = "decimal(5,2")]
        public decimal NoiseLevel { get; set; } // In dB
        [Column(TypeName = "decimal(10,2")]
        public decimal PowerConsumption { get; set; } // In Watts

        public virtual Brand Brand { get; set; }
        public virtual Product Product { get; set; }    
    }
}
