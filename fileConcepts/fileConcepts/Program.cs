using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileConcepts
{
	class Program
	{
		static string path = @"D:\files\sample.txt";
		public static  void createFile()
		{
			
			FileStream fs = File.Create(path);

		}
		public static void writeFile()
		{
			File.WriteAllText(path, "Test to wrote");
		}
		public static void display()
		{
			string text = File.ReadAllText(path);
			Console.WriteLine(text);
		}
		public static void delete()
		{
			File.Delete(path);
		}
		static void Main(string[] args)
		{
			//createFile();
			writeFile();
			//display();
			//delete();
			Console.ReadKey();
		}
	}
}
