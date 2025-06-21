using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Reviews",Schema ="Reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Required(ErrorMessage = "Id customer is required.")]
        public int Customerid { get; set; }
        [Required(ErrorMessage = "Id product  is required.")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Id oder  is required.")]
        public int OrderId { get; set; }
        [Range(1,5,ErrorMessage =" Rating must be from 1 to 5.")]
        public int Rating { get; set; }
        public string Comments { get; set; }
        [StringLength(150,ErrorMessage = "Review title no more than 150 characters.")]
        public string ReviewTitle { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;

        //navigation
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
