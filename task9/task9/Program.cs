using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
	class Helicopter:Air
	{
		int numberOfBlades ;
		
		double fuelCapacity,maxAltitude;
		public Helicopter() { }
		public Helicopter(int blades,double fc,double ma)
		{
			fuelCapacity = fc;
			numberOfBlades = blades;
			maxAltitude = ma;

		}
		public void fly()
		{
			Console.WriteLine("Helicopter Details");
			Console.WriteLine("Fuel Capacity:{0}\nNumber Of Blades:{1}\nMaxAltitude:{2}",fuelCapacity,numberOfBlades,maxAltitude);
		}
	}
	class Aeroplane : Air
	{
		double fuelCapacity;
		string flightNumber;
		public Aeroplane() { }
		public Aeroplane(double fuelCapacity,string fn)
		{
			this.fuelCapacity = fuelCapacity;
			flightNumber = fn;
		}
		public void fly()
		{
			Console.WriteLine("Aeroplane Details");
			Console.WriteLine("Flight Namae:{0}\nFuelCapacity:{1}",flightNumber,fuelCapacity);
		}
		class Program
		{
			public static void Main(String[] arg)
			{
				Helicopter h = new Helicopter(4,50.6,400);
				Aeroplane a = new Aeroplane(200,"BOEING777");
				h.fly();
				a.fly();
				Console.ReadKey();
			}
		}
	}
}
