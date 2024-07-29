using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database.Models
{
	public class Property
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string Location { get; set; }

		[Required]
		public double Price { get; set; }

		[Required]
		public string Status { get; set; }

		[Required]
		public string CreatedAt { get; set; }

		[Required]
		public string UpdatedAt { get; set; }



		//// Relationship => Many to One with User. Many Side = Property
		//[Required]
		//[ForeignKey("User")]
		//public int Agent_ID { get; set; }
		//public virtual User User { get; set; }

		/////===================================================================///

		//// Relationship => One to Many with Appointment. One-Side = Property
		//public virtual ICollection<Appointment> Appointments { get; set; }

		//public Property() 
		//{
		//	Appointments = new List<Appointment>();
		//}
	}
}