using Dream_Housing.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Dream_Housing.DTOs
{
	public class AppointmentDTO
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Date is required.")]
		[RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "Date must be in the format YYYY-MM-DD.")]
		public string Date { get; set; }

		[Required(ErrorMessage = "Time is required.")]
		[RegularExpression(@"^(?:[01]\d|2[0-3]):[0-5]\d$", ErrorMessage = "Time must be in the format HH:mm (24-hour).")]
		public string Time { get; set; }

		[Required(ErrorMessage = "Status is required.")]
		[RegularExpression("Scheduled|Completed|Cancelled", ErrorMessage = "Status must be either 'Scheduled', 'Completed', or 'Cancelled'.")]
		public string Status { get; set; }

		[CurrentDateTime]
		public string CreatedAt { get; set; }

		[CurrentDateTime]
		public string UpdatedAt { get; set; }

		[Required(ErrorMessage = "Client ID is required.")]
		public int Client_ID { get; set; }

		[Required(ErrorMessage = "Property ID is required.")]
		public int Property_ID { get; set; }
	}
}
