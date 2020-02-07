using System;

namespace lambdaDemo
{
    class Program
    {

		public static void lambda()
		{
			Func<int, int,int> triangle = (a, b) => (a * b) / 2;
			Console.WriteLine(triangle(4, 6));
		}
		public static string changeCase(Func<string, string> uc)
		{
			return uc("");
		} 
        static void Main(string[] args)
        {
			string s = "saravanan";
			lambda();
			Console.Write(changeCase(r => s.ToUpper()));
			Console.ReadKey();
        }
    }
}
