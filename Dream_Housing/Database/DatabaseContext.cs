using Dream_Housing.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database
{

	public class DatabaseContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Property> Properties { get; set; }
		public DbSet<Agent> Agents { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }
		public DbSet<Client> Clients { get; set; }

	}

}