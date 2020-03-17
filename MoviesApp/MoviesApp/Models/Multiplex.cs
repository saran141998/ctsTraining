using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
	public class Multiplex
	{
		[Key]
		[Required]
		public int MyProperty { get; set; }
	}
}