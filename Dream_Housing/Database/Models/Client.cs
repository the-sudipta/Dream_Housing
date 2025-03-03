﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database.Models
{
	public class Client
	{
		// This property is both the primary key and the foreign key.
		[Key, ForeignKey("User")]
		public int Id { get; set; }

		[Required]
		public int User_ID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string ContactInfo { get; set; }

		[Required]
		public string Preferences { get; set; }

		[Required]
		public string CreatedAt { get; set; }

		[Required]
		public string UpdatedAt { get; set; }

		// Navigation property to the User entity.
		public virtual User User { get; set; }

		// Relationship => One to Many with Appointment. One-Side = Client
		public virtual ICollection<Appointment> Appointments { get; set; }

		public Client()
		{
			Appointments = new List<Appointment>();
		}
	}
}