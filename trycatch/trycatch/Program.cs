using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
	class Program
	{

		public static long convert(DateTime e)
		{

			return ((DateTimeOffset)e).ToUnixTimeSeconds();

		}
		
		static void Main(string[] args)
		{
			//Console.WriteLine("Enter the Numerator");
			//int num= Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Enter the denominator");
			//int deno = Convert.ToInt32(Console.ReadLine());


			DateTime foo = DateTime.Now;
			DateTime bd = new DateTime(1998, 07, 14);
			Console.WriteLine(foo.Year - bd.Year);
			long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();
			var dateTime = DateTimeOffset.FromUnixTimeSeconds(unixTime).DateTime.ToLocalTime();
			//Console.WriteLine(foo.ToString("F"));

			//var localTime = new DateTime(dateTime.Ticks).ToLocalTime();
			//Console.WriteLine("Date and Time Now:{0}",DateTime.Now);
			//Console.WriteLine("UnixTime:{0}\nLocal Time:{1}",unixTime,dateTime);
			//try
			//{
			//	if (deno != 0)
			//	{
			//		num = num / deno;
			//		Console.WriteLine(num);
			//	}
					
			//}
			//catch(DivideByZeroException de)
			//{
			//	Console.WriteLine(de.Message);
			//}
			Console.ReadKey();
		
			
		}
	}
}
