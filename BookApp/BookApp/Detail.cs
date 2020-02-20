﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
	class Detail
	{
		[Key]
		public int DetailId { get; set; }
		public int BookId { get; set; }
		public int AuthorId { get; set; }
		public virtual Book Book { get; set; }
		public virtual Author Author { get; set; }
	}
}
