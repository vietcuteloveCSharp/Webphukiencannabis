using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Categories", Schema = "Products")]
    public class Category
    {
        [Key]    
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100,ErrorMessage = "Category name not more than 100 characters.")]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //navigation
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<PromotionCategory> PromotionCategories { get; set; }

    }
}
