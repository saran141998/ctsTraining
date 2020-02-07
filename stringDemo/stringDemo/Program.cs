using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringDemo
{
	class Program
	{
		public static string split(string[] s)
		{
			return string.Join(" ",s);

		}
		public static string[] splitArray(string s)
		{
			return s.Split();
		}
		public static StringBuilder fullName(StringBuilder firstName, StringBuilder lastName)
		{
			return firstName.Append(" ").Append(lastName);

		}
		static void Main(string[] args)
		{
			StringBuilder firstName = new StringBuilder("Saravanan");
			StringBuilder lastName = new StringBuilder("Ravi");
			Console.WriteLine(fullName(firstName, lastName));
			string s = "The quick brown fox jumps over";
			string[] str = s.Split(' ');
			Console.WriteLine(split(str));
			Console.ReadKey();
		}
	}
}
