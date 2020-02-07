using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		public static double Avg(int[] a)
		{
			double sum = 0;
			
			for(int i = 0; i < a.Length; i++)
			{
				sum += a[i];
			}

			return sum / a.Length;
		}
		static void Main(string[] args)
		{
			
			int[] a = { 85, 88,75, 95, 65,70};
			int[] b = { 1, 2, 3, 4, 5, 6, 7 };

			//var sum=a.Except(b).Union(b.Except(a)).ToArray();
			//foreach (int n in sum)
			//	Console.WriteLine(n);
			Console.WriteLine(Avg(a));
			Console.ReadKey();
		}
	}
}
