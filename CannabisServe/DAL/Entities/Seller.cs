using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;
using DAL.Inherited;
using static Enum.EnumableClass.EnumableClass;

namespace DAL.Entities
{
    [Table("Sellers", Schema = "Users")]
    public class Seller :Tokens
    {
        [Key]
        public int SellerId { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(100, ErrorMessage = "Username no more than 100 characters.")]
        public string Username { get; set; }
        public string HashPassword { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } =DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public ESellerSatus Satus { get; set; }
        [Required(ErrorMessage ="Id role is required.")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
       

    }
}
