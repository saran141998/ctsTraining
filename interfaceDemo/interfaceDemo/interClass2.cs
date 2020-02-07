using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceDemo
{
	class Bike
	{
		string vehicleNo,Name,Chasis,EngineNo;

		public void getVehicleDetails(string vno,string n,string chasis,string eno)
		{
			vehicleNo = vno;
			Name = n;
			Chasis = chasis;
			EngineNo = eno;
		}
		public void showVehicleDetails()
		{
			Console.WriteLine("Vehicle No:{0}\nName:{1}", vehicleNo, Name);
		}
	}
	interface Idrone
	{
		
       void calculateInsurance(DateTime d1,DateTime d2);

	}
}
