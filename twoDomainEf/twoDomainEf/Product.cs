using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDomainEf
{
	class Product
	{
		[Key]
		public int ProductId { get; set; }
		[MaxLength(250)]
		public string ProductName { get; set; }
		[Required]
		public double price { get; set; }

		public virtual ICollection<Purchase> Purchases { get; set; }
	}
}
