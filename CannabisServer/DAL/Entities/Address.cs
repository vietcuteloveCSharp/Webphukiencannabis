using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        [Required(ErrorMessage ="Id Customer Is Required")]
        public int CustomerId { get; set; }
        [StringLength(150, ErrorMessage = "Country name cannot exceed 150 characters.")]
        public string Country { get; set; }

        [StringLength(150, ErrorMessage = "Province name cannot exceed 150 characters.")]
        public string Province { get; set; }

        [StringLength(150, ErrorMessage = "District name cannot exceed 150 characters.")]
        public string District { get; set; }

        [StringLength(150, ErrorMessage = "Commune name cannot exceed 150 characters.")]
        public string Commune { get; set; }

        [StringLength(150, ErrorMessage = "Road_Village_Hamlet name cannot exceed 150 characters.")]
        public string Road_Village_Hamlet { get; set; }

        [StringLength(20, ErrorMessage = "HouseNumber cannot exceed 20 characters.")]
        public string HouseNumber { get; set; }

        [StringLength(30, ErrorMessage = "PostalCode cannot exceed 30 characters.")]
        public string PostalCode { get; set; }

        public bool IsDefault {  get; set; } =false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } 
        

        //navigation
        public virtual Customer Customer { get; set; }
    }
}
