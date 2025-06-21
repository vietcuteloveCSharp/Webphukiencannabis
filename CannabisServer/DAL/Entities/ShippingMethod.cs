using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("ShippingMethod",Schema ="Oders")]
    public class ShippingMethod
    {
        [Key]
        public int ShippingId {  get; set; }
        [Required(ErrorMessage ="Id Order is required.")]
        public int OrderId {  get; set; }
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(150, ErrorMessage = "Name no more than 150 characters.")]
        public string Name { get; set; }     
        [Required(ErrorMessage = "Carrier is required.")]
        [StringLength(150, ErrorMessage = "Carrierno more than 150 characters.")]
        public string Carrier { get; set; }   
        public int EstimatedDeliveryDate { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        //navigation
        public virtual Order Order { get; set; }
    }
}
