using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Brands", Schema = "Products")]
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required(ErrorMessage ="Brand name is required.")]
        [StringLength(255,ErrorMessage = "Brand name cannot exceed 255 characters.")] 
        public string BrandName { get; set; }
        [StringLength(150, ErrorMessage = "Country name cannot exceed 150 characters.")]
        public string Country { get; set; }
        public string Description { get; set; }
        [StringLength(255,ErrorMessage = "Website link cannot exceed 255 characters.")]
        public string Website {  get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } =DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<Nutrient> Nutrients { get;set; }
        public virtual ICollection<CarbonFilter> CarbonFilters { get; set; }
        public virtual ICollection<GrowTent> GrowTents { get; set; }
        public virtual ICollection<Dehumidifier> Dehumidifiers { get; set; }
        public virtual ICollection<GrowLight> GrowLights { get; set; }


    }
}
