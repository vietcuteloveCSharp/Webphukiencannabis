using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Carts", Schema = "Orders")]
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [Required(ErrorMessage ="Id customer is required.")]
        
        public int CustomerId {  get; set; }
        [Required(ErrorMessage = "Id Session is required.")]
        [MaxLength(255,ErrorMessage = "Session no more than 255 characters.")]
        public string Session_Id { get; set; }
        
        public int Quantity { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; } //khi thêm vào giỏ hàng lưu giá lại 
        
        public DateTime Date_Added {  get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Total_Price {  get; set; }

        //navigation 
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartDetails> CartDetails { get; set; } = new List<CartDetails>();
        
    
        
    }
}
