using Dream_Housing.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }

		[Required]
		public string Role { get; set; }

		[Required]
		public string CreatedAt { get; set; }

		[Required]
		public string UpdatedAt { get; set; }



		// One to One Navigation property to the Agent entity.
		public virtual Agent Agent { get; set; }

		// One to One Navigation property to the Client entity.
		public virtual Client Client { get; set; }

		// Relationship => One to Many with Property. One-Side = User
		//public virtual ICollection<Property> Properties { get; set; }

		// Relationship => One to Many with Appointment. One-Side = User
		//public virtual ICollection<Appointment> Appointments { get; set; }

		//public User()
		//{
		//	Properties = new List<Property>();
		//	////Appointments = new List<Appointment>();
		//}
	}
}