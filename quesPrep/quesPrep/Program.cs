using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quesPrep
{
	class Program
	{
		static string path = @"D:\files\sample.txt";
		static ArrayList al = new ArrayList();
		static string final = "";
		public static void makeArray(string[] s, int n)
		{
			int si = 0;
			int ei = n;
			for (int j = 0; j < s.Length / 4; j++)
			{
				for (int i = si; i < n; i++)
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
			string text = File.ReadAllText(path);
			string[] str = text.Split();
			File.WriteAllText(path, string.Empty);
			foreach(string s in str)
			{
				Console.WriteLine(s);
			}
			Console.ReadKey();
		}
	}
}
