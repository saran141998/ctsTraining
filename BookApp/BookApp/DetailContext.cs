using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace BookApp
{
	class DetailContext:DbContext
	{
		public DetailContext() : base("DetailContext") { }
		public DbSet<Book> books { get; set; }
		public DbSet<Author> authors { get; set; }
		public DbSet<Detail> details { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
