using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Classifies")]   
    public class Classification
    {
       
        [Key]
        public int ClassificationId { get; set; }
        [Required(ErrorMessage = "ClassificationName is required.")]
        [StringLength(150,ErrorMessage = "ClassificationName no than more 150 characters.")]
        public string ClassificationName { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public bool IsActive {  get; set; } =true;
        //navigation

        public virtual ICollection<Seed> Seeds { get; set; } 
    }
}
