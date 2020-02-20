using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDomainEf
{
	class Program
	{
	 public static	StoreContext sc = new StoreContext();
		static void Main(string[] args)
		{
			//insertInitialData();
			//addPurchaseDetails();
			showPurchases();
			Console.ReadKey();
		}
		
		private static void insertInitialData()
		{
			StoreContext sc = new StoreContext();
			var customers = new List<Customer>
			{
				new Customer{ CustomerName="Saravanan",CustomerMobile="9500761918",CustomerEmail="saravanansr98@gmail.com"},

				new Customer{ CustomerName="Rohith",CustomerMobile="9500764565",CustomerEmail="rohith98@gmail.com"},

				new Customer{ CustomerName="Rishi",CustomerMobile="8525761918",CustomerEmail="rishipop8@gmail.com"}

			};
			customers.ForEach(s => sc.Customers.Add(s));
			sc.SaveChanges();

			var products = new List<Product>
			{
				new Product{ ProductName ="Sprite",price=35.4},

				new Product{ ProductName="Cococola",price=40},

				new Product{ ProductName="GoodDay",price=10}

			};
			products.ForEach(p => sc.Products.Add(p));
			sc.SaveChanges();
			
		}

		private static void addPurchaseDetails()
		{
			StoreContext sc = new StoreContext();
			var purchases = new List<Purchase>
			{
				new Purchase{ purchaseDate=DateTime.Now,CustomerID=5,ProductId=2},
				new Purchase{ purchaseDate=DateTime.Now,CustomerID=5,ProductId=1}
			};
			purchases.ForEach(pur => sc.Purchases.Add(pur));
			sc.SaveChanges();
		}
		private static void showPurchases()
		{
		
			StoreContext sc = new StoreContext();
			var customers = sc.Customers;
			Console.WriteLine("Customer Details");
			foreach (var cus in customers)
			{
				Console.WriteLine("{0}\t{1}\t{2}\t{3}", cus.CustomerID, cus.CustomerName, cus.CustomerMobile, cus.CustomerMobile);
			}
			var products = sc.Products;
			Console.WriteLine("Product Details");
			foreach (var cus in products)
			{
				Console.WriteLine("{0}\t{1}\t{2}", cus.ProductId, cus.ProductName, cus.price);
			}
			var purchases = sc.Purchases;
			Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}{6,15}","PurchID","PurchaseDate","ProductId","Product Name","Price","CustomerID","CustomerName");
			foreach(var cus in purchases)
			{
				
				Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}{6,15}", cus.Id,cus.purchaseDate.ToShortDateString(),cus.ProductId,cus.Product.ProductName,cus.Product.price,cus.CustomerID,cus.Customer.CustomerName);
			}
		}
	}
}
