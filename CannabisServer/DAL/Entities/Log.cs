using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Logs",Schema ="Logs")]
    public class Log
    {
        [Key]
        public int LogId {  get; set; }
        [Required(ErrorMessage = "Id Seller is required.")]
        public int SellerId {  get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public virtual Seller Seller { get; set; }
    }
}
