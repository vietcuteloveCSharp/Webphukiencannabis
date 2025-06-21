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
    [Table("Roles",Schema = "Users")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required(ErrorMessage ="Role name is required.")]
        public ERoleName RoleName { get; set; }
        public string Description { get; set; }

        public ICollection<Seller> Sellers { get; set; }
    }
}
