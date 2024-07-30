using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database.Models
{
	public class Appointment
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Date { get; set; }

		[Required]
		public string Time { get; set; }

		[Required]
		public string Status { get; set; }

		[Required]
		public string CreatedAt { get; set; }

		[Required]
		public string UpdatedAt { get; set; }

		[Required]
		[ForeignKey("Client")]
		public int Client_ID { get; set; }
		public virtual Client Client { get; set; }

		/////===================================================================///

		[Required]
		[ForeignKey("Property")]
		public int Property_ID { get; set; }
		public virtual Property Property { get; set; }




	}
}