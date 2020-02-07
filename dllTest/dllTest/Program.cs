using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;

namespace dllTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculation c = new Calculation();
			c.num1 = 40;
			c.num2 = 50;
			Console.WriteLine(c.add());
			Console.WriteLine(c.difference());
			Console.ReadKey();
		}
	}
}
