using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstApproach
{
	class Program
	{
		static ModelFirstEntityContainer mc = new ModelFirstEntityContainer();
		static void Main(string[] args)
		{
			//createCategory();
			//createProduct();
			showAll();
			Console.ReadKey();
		}

		private static void createProduct()
		{
			var product = new List<Product>
			{
				new Product{ ProId=1,ProName="Mazza",Price=35.60,CategoryId=1},
				new Product{ProId=2,ProName="Mysore Sandal",Price=32.60,CategoryId=2 }
			};
			product.ForEach(pro => mc.Products.Add(pro));
			mc.SaveChanges();
		}
		private static void createCategory()
		{
			var category = new List<Category>
			{
				new Category{ CategoryId=1,CategoryName="Food"},
				new Category{CategoryId=2,CategoryName="Soaps"}
			};
			category.ForEach(ctg => mc.Categories.Add(ctg));
			mc.SaveChanges();
		}
		private static void showAll()
		{
			var categories = mc.Categories;
			Console.WriteLine("{0,-8}{1,-10}", "CategoryId","CategoryName");
			foreach(var c in categories)
			{
				Console.WriteLine("{0,-8}{1,-10}", c.CategoryId, c.CategoryName);
			}

			var products = mc.Products;
			Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}", "ProId", "ProName", "Price", "CategoryId", "CategoryName");
			foreach(var p in products)
			{
				Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}", p.ProId, p.ProName, p.Price, p.CategoryId);
			}

		}
	}
}
