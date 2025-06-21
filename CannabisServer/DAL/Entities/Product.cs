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
    [Table("Products", Schema = "Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Product name is required.")]
        [StringLength(255, ErrorMessage = "Product name no more than 255 characters.")]
        public string ProductName { get; set; }
       
        [Required(ErrorMessage ="Id category is required.")]
        public int CategoryId { get; set; } 
        public bool IsActive { get; set; } =true;
        public EProductType ProductType { get; set; }
        public int ProductTypeId {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        //naviagtion
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<CartDetails> CartsDetails { get; set; } = new List<CartDetails>();
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public virtual ICollection<OrderItem> OderItems { get; set; } 
        public virtual Category Category { get; set; }
        public virtual Seed Seed { get; set; }
        public virtual Nutrient Nutrient { get; set; }
        public virtual Dehumidifier Dehumidifier { get; set; }
        public virtual GrowTent GrowTent{ get;set; }
        public virtual GrowLight GrowLight { get; set; }
        public virtual CarbonFilter CarbonFilter { get; set; }
        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; }
    }
}
