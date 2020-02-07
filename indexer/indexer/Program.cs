using System;

namespace indexer
{
	
	class Gencl<T>
    {
		private T[] arr=new T[100];
		public T this[int i]
		{
			get
			{
				return arr[i];
			}
			set
			{
				arr[i] = value;
			}
		}	
    }
	class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double price { get; set; }
		public static void Main(string[] args)
		{
			Gencl<Product> g = new Gencl<Product>();
			Product p1 = new Product();
			Product p2 = new Product();
			p1.Id = 1;
			p1.Name = "Cococola";
			p1.price = 35.5;
			p2.Id = 2;
			p2.Name = "Miranda";
			p2.price = 35.3;
			g[0] = p1;
			g[1] = p2;
			Console.WriteLine(g[0].Id);
			Console.ReadKey();
		}
	}
}
