using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database.Models
{
	public class Feedback
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int Property_ID { get; set; }

		[Required]
		public int Client_ID { get; set; }

		[Required]
		public string Rating { get; set; }

		[Required]
		public string Comments { get; set; }

		[Required]
		public string SubmittedAt { get; set; }
	}
}