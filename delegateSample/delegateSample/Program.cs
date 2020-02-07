using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateSample
{
	public delegate int delDemo(int x, int y);
	public delegate string sq(int x);
	class Program
	{
		
		public static int add(int a,int b)
		{
			return a + b;
		}
		public static int sub(int a,int b)
		{
			return a - b;
		}
		public static string area(int a)
		{
			return Convert.ToString(a * a);
		}
		static void Main(string[] args)
		{
			delDemo d = new delDemo(add);
			Console.WriteLine(d(12, 13));
			d += new delDemo(sub);
			sq s = new sq(area);
			Console.WriteLine("Area of a Square:{0}",s(2));
			Console.WriteLine(d(12,13));
			Console.ReadKey();
		}
	}
}
