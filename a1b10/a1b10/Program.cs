using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1b10
{
	class Program
	{
		public static void print(char a,int count)
		{
			for(int i = 0; i < count; i++)
			{
				Console.Write(a);
			}
		}
		static void Main(string[] args)
		{
			int sum = 0;
			string str = "a23b12";
			//output:aabbbbbbbbbbbb
			int count=0;
			for(int i = 0; i < str.Length-2; i++)
			{
				
				if((str[i]>=48 && str[i] <= 57) && (str[i+1]>=48 && str[i+1]<=57))
				{
					count = (str[i] - 48) * 10 + (str[i + 1] - 48);
					Console.WriteLine(count);
					sum = sum + count;
					
				}
				else if(str[i]>=48 && str[i]<=57){
					count = str[i] - 48;
					sum = sum + count;
					Console.Write("Test");
				}
			}
			Console.Write(sum);
			Console.ReadKey();
		}
	}
}
