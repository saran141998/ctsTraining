using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
	public class Movie
	{
		[Key]
		[Required]
		public string MovieName { get; set; }
		[Required]
		public string Genere { get; set; }
		[Required]
		[DataType(DataType.DateTime)]
		public DateTime MovieReleaseDate { get; set; }
	}
}