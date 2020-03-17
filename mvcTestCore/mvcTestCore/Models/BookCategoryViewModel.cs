using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcTestCore.Models
{
	public class BookCategoryViewModel
	{
		public List<Book> books { get; set; }
		public SelectList Categories { get; set; }
		public SelectList Publishers { get; set; }

		public string BookCategory { get; set; }

		public string BookPublisher { get; set; }
		public string SearchStr { get; set; }
	}
}
