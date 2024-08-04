using Dream_Housing.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Dream_Housing.DTOs
{
	public class FeedbackDTO
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Property ID is required.")]
		public int Property_ID { get; set; }

		[Required(ErrorMessage = "Client ID is required.")]
		public int Client_ID { get; set; }

		[Required(ErrorMessage = "Rating is required.")]
		[Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
		public int Rating { get; set; }

		[Required(ErrorMessage = "Comments are required.")]
		[StringLength(1000, ErrorMessage = "Comments must not exceed 1000 characters.")]
		public string Comments { get; set; }

		[CurrentDateTime]
		public string SubmittedAt { get; set; }
	}
}
