using Dream_Housing.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dream_Housing.DTOs
{
	public class PropertyDTO
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Title is required.")]
		[StringLength(100, ErrorMessage = "Title must not exceed 100 characters.")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Description is required.")]
		[StringLength(1000, ErrorMessage = "Description must not exceed 1000 characters.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Location is required.")]
		[StringLength(200, ErrorMessage = "Location must not exceed 200 characters.")]
		public string Location { get; set; }

		[Required(ErrorMessage = "Price is required.")]
		[Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
		public double Price { get; set; }

		[Required(ErrorMessage = "Status is required.")]
		[RegularExpression("Available|Sold|Pending", ErrorMessage = "Status must be either 'Available', 'Sold', or 'Pending'.")]
		public string Status { get; set; }

		[CurrentDateTime]
		public string CreatedAt { get; set; }

		[CurrentDateTime]
		public string UpdatedAt { get; set; }

		[Required(ErrorMessage = "Agent ID is required.")]
		public int Agent_ID { get; set; }
	}
}
