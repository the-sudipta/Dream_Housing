using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dream_Housing.Annotations
{
	public class CurrentDateTime : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			// Check if the property is null or empty
			if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
			{
				// Set the property to current DateTime
				var propertyInfo = validationContext.ObjectType.GetProperty(validationContext.MemberName);
				if (propertyInfo != null && propertyInfo.PropertyType == typeof(string))
				{
					propertyInfo.SetValue(validationContext.ObjectInstance, DateTime.Now.ToString("o")); // ISO 8601 format
				}
			}

			return ValidationResult.Success; // No error message needed
		}
	}
}