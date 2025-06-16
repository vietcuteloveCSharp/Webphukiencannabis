using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("NutrientTypes",Schema = "Inventory")]   
    public class NutrientType
    {
        [Key]
        public int NutrientTypeId { get; set; }
        [Required(ErrorMessage = "Nutrient name is required.")]
        [StringLength(150,ErrorMessage = "Nutrient name no more than 150 characters.")]
        public string NutrientName { get; set; }
        public string Description { get; set; }
        //navigation 
        public virtual ICollection<Nutrient> Nutrients { get; set; }
    }
}
