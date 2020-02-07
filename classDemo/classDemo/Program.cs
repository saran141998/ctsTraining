using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classDemo
{
	class Program
	{
		int x = 10, y = 9;
		public int mul()
		{
			return x * y;
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			Console.WriteLine(p.mul());
			Console.ReadKey();
		}
	}
}
