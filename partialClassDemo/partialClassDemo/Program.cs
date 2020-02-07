using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClassDemo
{
	
		public partial class class1
		{
			 public string name = "Saravanan";
		}
	    public partial class class1
	    {
		public int age = 21;

	    }
	public class Program {

		static void Main(string[] args)
		{
			class1 p = new class1();
			Console.WriteLine(p.name);
			Console.WriteLine(p.age);
			Console.ReadKey();
		}
	}
	
		
	
}
