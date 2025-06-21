using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Breeders")]
    public class Breeder
    {
        [Key]
        public int BreederId { get; set; }
        [Required(ErrorMessage ="Breeder is requied.")]
        [StringLength(255 ,ErrorMessage = "Breeder name cannot exceed  255 characters.")]
        public string BreederName { get; set; }
        [StringLength(150, ErrorMessage = "Country name cannot exceed 150 characters.")]
        public string Country { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdateAt { get; set; }
        [StringLength(255, ErrorMessage = "Website link cannot exceed 255 characters.")]
        public string Website {  get; set; }
        public bool IsActive { get; set; }=true;
        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress(ErrorMessage ="Email invalid.")]
        public string Email {  get; set; }
        public string PhoneNumber { get; set; }

        //navigation
        public virtual ICollection<Seed> Seeds { get; set; }
    }
}
