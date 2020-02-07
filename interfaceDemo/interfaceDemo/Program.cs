using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceDemo
{
	class Program:Bike,Idrone
	{
		
		public void calculateInsurance(DateTime d1,DateTime d2)
		{
			if (((d2 - d1).TotalDays) > 365)
			{
				Console.WriteLine("Your Insurance has Expired");
			}
		}
		
		static void Main(string[] args)
		{
			DateTime d1 = Convert.ToDateTime("12/24/2010");
			Program p = new Program();
			p.getVehicleDetails("T12334", "CDDELUXE", "CHCDJ776", "ENG789");
			p.showVehicleDetails();
			p.calculateInsurance(d1,Convert.ToDateTime("12/03/2011"));
			Console.ReadKey();
		}
	}
}
