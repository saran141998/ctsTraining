using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullname
{
	class Program
	{
		public static StringBuilder fullName(StringBuilder firstName,StringBuilder lastName)
		{
			return firstName.Append(" ").Append(lastName);
			
		}
		static void Main(string[] args)
		{
			StringBuilder firstName = new StringBuilder("Saravanan");
			StringBuilder lastName = new StringBuilder("Ravi");
			Console.WriteLine(fullName(firstName,lastName));
			Console.ReadKey();
		}
	}
}
