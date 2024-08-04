using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database.Models
{
	public class Feedback
	{
		[Key]
		public int Id { get; set; }

		// Relationship => Many to One with Property. Many Side = Feedback
		[Required]
		[ForeignKey("Property")]
		public int Property_ID { get; set; }
		public virtual Property Property { get; set; }

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