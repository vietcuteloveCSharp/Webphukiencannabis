using DAL.Inherited;
using Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.EnumableClass.EnumableClass;

namespace DAL.Entities
{
    [Table("Customers",Schema ="Users")]   
    public class Customer : Tokens
    {
        [Key]
        public int CustomerId {  get; set; }
        [Required(ErrorMessage ="Username is required.")]
        [StringLength(100,ErrorMessage ="Username no more than 100 characters.")]
        public string Username { get; set; }
        public string HashPassword {  get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress(ErrorMessage ="Invalid email.")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Is_anonymous {  get; set; }=false;
        public DateTime CreatedAt { get; set; } =DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public ECustomerStatus Status {  get; set; } 
       

        //navigation
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }



    }
}
