using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("CartSatus", Schema = "Orders")]
    public class CartStatus
    {
        [Key]
        public int CartSatusId {  get; set; }
        [Required(ErrorMessage ="Cart satus name is required.")]
        [StringLength(100,ErrorMessage = "Cart status name no more than 100 characters.")]
        public string CartSatusName { get; set; }
        //navigation
        public virtual ICollection<CartDetails> CartDetails { get; set; } = new List<CartDetails>();

    }
}
