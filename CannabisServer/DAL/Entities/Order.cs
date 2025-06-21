using Enum.EnumableClass;
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
    [Table("Orders",Schema = "Orders")]   
    public class Order
    {
        [Key]
        public int  OrderId { get; set; }
        [Required(ErrorMessage ="Id customer is required.")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Id seller is required.")]

        public int SellerId {  get; set; }
        [Column(TypeName ="nvarchar(20)")]
        public EOrderSatus OrderSatus {  get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal TotalAmount {  get; set; }
        public string ShippingAddress {  get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal ShippingFee {  get; set; }
        [Column(TypeName = "varchar(50)")]
        public string TrackingNumber {  get; set; } 
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        //navigation
        public virtual Customer Customer { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ShippingMethod ShippingMethod { get; set; }
        public virtual Payment Payment { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
