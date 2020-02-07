using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary
{
	class Program
	{
		static ArrayList al = new ArrayList();
		public static void binary(int a)
		{
			while (a > 0)
			{
				al.Add(a % 2);
				a /= 2;

			}
			reverse(al);
		}
		public static void reverse(ArrayList a)
		{
			a.Reverse();
			foreach(int i in a)
			{
				Console.Write(i);
			}
			Console.WriteLine();
			a.Clear();
		}

		static void Main(string[] args)
		{
			
			int a = 9;
			for(int i = 1; i <= a; i++)
			{
				binary(i);
			}
			al.Reverse();
			Console.ReadKey();
		}
	}
}
