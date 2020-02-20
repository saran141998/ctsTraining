using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookApp
{
	class Book
	{
		[Key]
		public int BookId { get; set; }
		[MaxLength(250)]
		[Required]
		public string Title { get; set; }
		[Required]
		public double price { get; set; }
		[Required]
		[MaxLength(50)]
		public string Genre { get; set; }
	}
}
