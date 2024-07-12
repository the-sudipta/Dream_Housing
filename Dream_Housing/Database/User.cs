using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dream_Housing.Models
{
	public class User
	{
        [Key]
        public int id { get; set; }
    }
}