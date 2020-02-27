using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace mvcTestCore.Models
{
	public class Seed
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context=new BookContext(serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
			{
				if (context.Books.Any())
				{
					return;
				}
				context.Books.AddRange(
					new Book
					{
						BookTitle = "Wings of fire",
						category = "Motivation",
						price = 250,
						AuthorName = "Apj.Abdul Kalam",
						Publisher="B2B Publishers"
					}
			   );
				context.SaveChanges();
			}
		}
	}
}
