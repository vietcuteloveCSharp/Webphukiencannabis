using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("OrderItems",Schema = "Orders")]
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        [Required(ErrorMessage = "Id oder is required.")]
        public int OderId {  get; set; }
        [Required(ErrorMessage = "Id product is required.")]
        public int ProductId {  get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public virtual Order Oder { get; set; }
        public virtual Product Product { get; set; }
    }
}
