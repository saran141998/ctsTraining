using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesDemo
{
	class propertiesDemo
	{
		string name = "Saravanan";

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}

		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			propertiesDemo pD = new propertiesDemo
			{
				Name = "Rohit"
			};
			Console.WriteLine(pD.Name);
			Console.ReadKey();
		}
	}
}
