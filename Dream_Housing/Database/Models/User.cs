﻿using System;
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
	}
}