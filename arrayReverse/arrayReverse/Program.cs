using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayReverse
{
	class Program
	{
		public static void arrayReverse(int[] a)
		{
			int temp = 0;
			int i = 0;
			int j = a.Length - 1;
			while (i < j)
			{
				temp = a[i];
				a[i] = a[j];
				a[j] = temp;
				i++;
				j--;
			}

			for(int si = 0; si < a.Length; si++)
			{
				Console.Write(a[si]);
				if (si != a.Length-1)
				{
					Console.Write(",");
				}
			}
			//for(int i = a.Length - 1; i >= 0; i--)
			//{
				
			//	Console.Write(a[i]);
			//	if (i != 0)
			//	{
			//		Console.Write(",");
			//	}
			//}

		}
		public static int evenNumberSum(int[] arr)
		{
			int sum = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0)
				{
					sum += arr[i];
				}
			}
			return sum;
		}
		static void Main(string[] args)
		{
			reverseArray();
			//evenSum();

			Console.ReadKey();
		}

		private static void evenSum()
		{
			int[] arr = { 3, 2, 5, 6, 8, 10, 9, 7 };
			Console.WriteLine(evenNumberSum(arr));
		}

		private static void reverseArray()
		{
			int[] a = { 1, 2, 3, 4 };
			arrayReverse(a);
			
		}
	}
}
