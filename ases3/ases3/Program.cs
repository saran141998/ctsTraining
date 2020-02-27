using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ases3
{

	class maths { 
		public int x; 
		public double y; 
		public int add(int a, int b) 
		{ 
			x = a + b;
			return x; 
		} 
		public int add(double c, double d) 
		{ 
			y = c + d; 
			return (int)y; 
		} 
		public maths() 
		{ 
			this.x = 0;
			this.y = 0; 
		} 
	}
	class Program 
	{
		static void Main(string[] args) 
		{
			int[,] a = { { 5, 4, 3 }, { 9, 2, 6 } };
			Console.WriteLine(a.GetUpperBound(0));
			Console.ReadKey();
		} 
	}



}
