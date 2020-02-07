using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousMethod
{
	public delegate void am(string s);
	class Program
	{
		static void Main(string[] args)
		{
			am anonymousMethod = a => Console.WriteLine(a);
			anonymousMethod("Saravanan");
			Console.ReadKey();
		}
	}
}
