using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dream_Housing.Annotations
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class Role : ValidationAttribute
	{
		private readonly HashSet<string> _validRoles;

		public Role(params string[] roles)
		{
			_validRoles = new HashSet<string>(roles, StringComparer.OrdinalIgnoreCase);
		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
			{
				return new ValidationResult("Role is required.");
			}

			var roles = value.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var role in roles)
			{
				if (!_validRoles.Contains(role.Trim()))
				{
					return new ValidationResult($"Invalid role: {role.Trim()}.");
				}
			}

			return ValidationResult.Success;
		}
	}
}