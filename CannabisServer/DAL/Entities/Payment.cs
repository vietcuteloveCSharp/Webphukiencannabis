using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Payments", Schema = "Orders")]
    public class Payment
    {
        [Key]
        public int PaymentId {  get; set; }
        [Required(ErrorMessage = "Id order  is required.")]
        public int OrderId {  get; set; }

        [StringLength(100,ErrorMessage = "Payment name no more than 100 characters.")]
        [Required(ErrorMessage = "Payment name is required.")]
        public string PaymentName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } =DateTime.Now;
        public DateTime updatedAt { get; set; }
        //navigation

        public virtual Order Order { get; set; } 

    }
}
