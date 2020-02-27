using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbertoword
{
	class Program
	{
		public static string numbertoword(int num)
		{
			string final = "";
			string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			while (num > 0)
			{
				final = final+" "+words[num%10];
				num = num / 10;
			}
			return final;
		}
		static void Main(string[] args)
		{
			string op=numbertoword(4136);
			string[] arr = op.Split();
		    for(int i =arr.Length-1; i >=0 ; i--)
			{
				Console.Write(arr[i] + " ");
			}
			Console.ReadKey();
		}
	}
}
