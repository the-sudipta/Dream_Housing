using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dream_Housing.Database
{

	public class DatabaseContext : DbContext
	{
		//public DatabaseContext() : base("name=DatabaseContext")
		//{
		//}


		public DbSet<User> Users { get; set; }


	}

}