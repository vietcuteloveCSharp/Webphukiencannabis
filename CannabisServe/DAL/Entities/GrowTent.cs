using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("GrowTents", Schema = "Inventory")]
    public class GrowTent
    {
        [Key]
        public int GrowtentId { get; set; }
        [Required(ErrorMessage ="Id brand is required.")]
        public int BrandId { get; set; }
        [StringLength(100,ErrorMessage = "Dimensions no more than 100 characters.")]
        public string Dimensions { get; set; }
        [StringLength(255, ErrorMessage = "Material no more than 255 characters.")]

        public string Material { get; set; }
        public bool Waterproof { get; set; }=false;
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2")]
        public decimal Price { get; set; }
        [StringLength(255, ErrorMessage = "Frame material no more than 255 characters.")]
        public string FrameMaterial { get; set; }
        public int WarrantyPeriod { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        //navigation

        public virtual Brand Brand { get; set; }
        public virtual Product Product { get; set; }

    }
}
