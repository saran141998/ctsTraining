using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
	class Program
	{
		static ArrayList al = new ArrayList();
		static string final = "";
		public static void makeArray(string[] s,int n)
		{
			int si = 0;
			int ei = n;
			for (int j=0;j<s.Length/4;j++)
			{
				for (int i = si; i<n; i++)
				{
					al.Add(s[i]);

				}
				rev(al);
				si += ei;
				n += ei;
			}
			Console.WriteLine(final);
		}
		public static void rev(ArrayList a1)
		{
			al.Reverse();
			foreach (string trs in al)
			{
				final = final + trs + " ";

			}
			a1.Clear();

		}
		static void Main(string[] args)
		{
			int n = 4;
			string s = "This is the first example for the program";
			string[] str = s.Split();
			makeArray(str, n);
			Console.ReadKey();
		}
	}
}
