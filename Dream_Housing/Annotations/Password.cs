using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Dream_Housing.Annotations
{
	public class Password : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var password = value as string;

			if (string.IsNullOrEmpty(password))
			{
				return new ValidationResult("Password is required.");
			}

			if (password.Length > 50)
			{
				return new ValidationResult("Password must not exceed 50 characters.");
			}

			var hasNumber = new Regex(@"[0-9]+");
			var hasUpperChar = new Regex(@"[A-Z]+");
			var hasLowerChar = new Regex(@"[a-z]+");
			var hasSymbols = new Regex(@"[@$!%*?&]+");

			if (password.Length < 8 ||
				!hasNumber.IsMatch(password) ||
				!hasUpperChar.IsMatch(password) ||
				!hasLowerChar.IsMatch(password) ||
				!hasSymbols.IsMatch(password))
			{
				return new ValidationResult("Password must be at least 8 characters long, and contain at least one number, one uppercase letter, one lowercase letter, and one special character.");
			}

			return ValidationResult.Success;
		}

	}
}