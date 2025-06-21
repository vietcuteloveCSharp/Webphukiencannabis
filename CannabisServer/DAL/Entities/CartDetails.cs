using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("CartDetails", Schema = "Orders")]
    public class CartDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartDetailsId { get; set; }
        [Required(ErrorMessage = "Id cart is required.")]
        public int CartId {  get; set; }
        [Required(ErrorMessage = "Id product is required.")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Id cart status is required.")]
        public int CartStatusId { get; set; }
        public int Quantity {  get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        //navigation
        public virtual CartStatus CartStatus { get; set; }
        public virtual Product Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
