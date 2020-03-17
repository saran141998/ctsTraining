using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDomainEf
{
	class Purchase
	{
		[Key]
		public int Id { get; set; }
		[DataType(DataType.Date)]
		public DateTime purchaseDate { get; set; }
			public int CustomerID { get; set; }
			public int ProductId { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual Product Product { get; set; }
	}
}
