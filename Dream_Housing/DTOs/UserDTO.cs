using Dream_Housing.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dream_Housing.DTOs
{
	public class UserDTO
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Invalid email address.")]
		public string Email { get; set; }

		//[Password]
		[Required(ErrorMessage = "Password is required.")]
		[StringLength(50, ErrorMessage = "Password must not exceed 50 characters.")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
		ErrorMessage = "Password must be at least 8 characters long, and contain at least one number, one uppercase letter, one lowercase letter, and one special character.")]
		public string Password { get; set; }

		// Applying the custom Role
		[Role("Admin", "Agent", "Client")] 
		public string Role { get; set; }

		[CurrentDateTime]
		public string CreatedAt { get; set; }

		[CurrentDateTime]
		public string UpdatedAt { get; set; }
	}
}