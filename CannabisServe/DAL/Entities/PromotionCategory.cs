using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Promotion_Category", Schema = "Promotions")]
    public class PromotionCategory
    {
        [Key]
        public int PromotionId { get; set; }
        [Key]
        public int CategoryId { get;set; }

        public virtual Promotion Promotion { get; set; }
        public  virtual Category Category { get; set; }

    }
}
