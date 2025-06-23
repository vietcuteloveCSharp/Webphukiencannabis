using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.EnumableClass.EnumableClass;

namespace DTO.CustomerDataTransferObj
{
    public class CustomerDTO
    {
		[Required(ErrorMessage = "Username is required.")]
		[StringLength(100, ErrorMessage = "Username no more than 100 characters.")]
		public string Username { get; set; } =string.Empty;
		[Required(ErrorMessage = "Password is required.")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.")]
		public string Password { get; set; } =string.Empty;
		[Required(ErrorMessage = "Name is required.")]
		[StringLength(50, ErrorMessage = "Name no more than 50 characters.")]
		public string Name { get; set; } =string.Empty;
		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Invalid email.")]
		public string Email { get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
	
		[Column(TypeName = "nvarchar(20)")]
		public ECustomerStatus Status { get; set; } = ECustomerStatus.Active;
	}
}
