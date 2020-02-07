using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spliStringDemo
{
	class Program
	{
		public static string[] splitArray(string s)
		{
			return s.Split();
		}
		static void Main(string[] args)
		{
			string s = "The quick brown fox jumps over the lazy dog";
			string[] strArray=splitArray(s);
			foreach(string str in strArray)
			{
				Console.WriteLine(str);
			}
			Console.ReadKey();
			
		}
	}
}
