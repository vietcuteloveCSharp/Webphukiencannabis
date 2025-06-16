using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("ProductImages", Schema = "Products")]
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        [Required(ErrorMessage = "Id product is required.")]
        public int ProductId { get; set; } // Foreign Key
        public string ImageUrl { get; set; } //link Cloudinary
        public bool IsMainImage { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        // Navigation Property
        public virtual Product Product { get; set; }
    }
}
