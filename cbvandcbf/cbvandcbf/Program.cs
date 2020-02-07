using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbvandcbf
{
	class Program
	{
		public static void cbv(int a,int b)
		{
			a = a + b;
			b = a - b;
			a = a - b;
			Console.WriteLine("After swapping with call by value a={0} and b={1}", a, b);
		}
		public static void cbr(ref int a,ref int b)
		{
			a = a + b;
			b = a - b;
			a = a - b;
			Console.WriteLine("After swapping with call by reference a={0} and b={1}", a, b);
		}
		static void Main(string[] args)
		{
			int a = 10;
			int b = 20;
			Console.WriteLine("Before Swapping a={0} and b={1}",a,b);
			cbv(a, b);
			Console.WriteLine("Finally After Swapping with CBV the values in Memory a={0} and b={1}", a, b);
			cbr(ref a, ref b);
			Console.WriteLine("Finally After Swapping with CBR the values in Memory a={0} and b={1}", a, b);
			Console.ReadKey();
		}
	}
}
