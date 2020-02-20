using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
	class Author
	{
		[Key]
		public int AuthorId { get; set; }
		[Required]
		[MaxLength(250)]
		public string AuthorName { get; set; }
		[Required]
		[MaxLength(250)]
		public string Address { get; set; }
	}
}
