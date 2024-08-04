using Dream_Housing.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Dream_Housing.DTOs
{
	public class AgentDTO
	{
		// This property is both the primary key and the foreign key.
		public int Id { get; set; }

		[Required(ErrorMessage = "User ID is required.")]
		public int User_ID { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		[StringLength(100, ErrorMessage = "Name must not exceed 100 characters.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Contact information is required.")]
		[StringLength(200, ErrorMessage = "Contact information must not exceed 200 characters.")]
		public string ContactInfo { get; set; }

		[CurrentDateTime]
		public string CreatedAt { get; set; }

		[CurrentDateTime]
		public string UpdatedAt { get; set; }
	}
}
