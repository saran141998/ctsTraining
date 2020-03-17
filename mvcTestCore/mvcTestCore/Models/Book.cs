using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvcTestCore.Models
{
	public class Book
	{
		[Required]
		[Key]
		public int BookId { get; set; }
		[Required]
		[Column(TypeName ="nvarchar(100)")]
		public string BookTitle { get; set; }
		[Column(TypeName ="nvarchar(100)")]
		[Required]
		public string category { get; set; }
		[DataType(DataType.Currency)]
		public double price { get; set; }
		[Required]
		[Column(TypeName = "nvarchar(100)")]
		public string AuthorName { get; set; }
		[Column(TypeName = "nvarchar(100)")]
		[Required]
		public string Publisher { get; set; }
	}
}
