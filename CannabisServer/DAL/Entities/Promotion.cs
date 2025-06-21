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
    [Table("Promotions", Schema = "Promotions")]
    public class Promotion
    {
        [Key]
        public int PromotionId { get; set; }
        [Required(ErrorMessage = "Promotion name is required.")]
        [StringLength(150, ErrorMessage = "Promotion name no more than 150 characters.")]
        public string PromotionName { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Discount type is required")]
        public EDiscountType DiscountType { get; set; }
        [Column(TypeName ="decimal(12,2)")]
        public decimal DiscountValue { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal MinimumOrderValue { get; set; }
        public int MinimumQuantity { get; set; } = 0;
        [Column(TypeName = "decimal(12,2)")]
        public decimal MaximumDiscountValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } =false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; }

        //navigation
        public virtual ICollection<PromotionCategory> PromotionCategories {  get; set; } =new List<PromotionCategory>();
        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; } = new List<PromotionProduct>();
    }
}
