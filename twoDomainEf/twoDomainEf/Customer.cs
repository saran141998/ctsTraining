using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDomainEf
{
	class Customer
	{
		[Key]
		public int CustomerID { get; set; }
		[Required]
		public string CustomerName { get; set; }
		[Required]
		public string CustomerMobile { get; set; }
		[Required]
		public string CustomerEmail { get; set; }

		public virtual ICollection<Purchase> Purchases { get; set; }

	}
}
