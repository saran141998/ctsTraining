using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SqlConnectionLibrary;

namespace insertAndSelect
{
	class Program
	{
		static string connectionString = @"Data Source=BLT1049\SQLEXPRESS2014;Initial Catalog=signup;Integrated Security=True;";
		//public static void insert(string Name,string Timings,string location,string regnum,float rating)
		//{
		//	SqlConLib cls = new SqlConLib();
		//	SqlConnection con = new SqlConnection(connectionString);
		//	con.Open();
		//	SqlCommand cmd;
		//	if(cls.record_available("select count(*) from Restaurant where regnum='" + regnum + "'"))
		//	{
		//		Console.WriteLine("Restaurant with the reg no already exists");
		//	}
		//	else
		//	{
		//		string query = "insert into Restaurant values('" + Name + "','" + Timings + "','" + location + "','" + regnum + "','" + rating + "')";
		//		cmd = new SqlCommand(query, con);
		//		int res = cmd.ExecuteNonQuery();
		//		if (res == 1)
		//		{
		//			Console.WriteLine("Inserted Successfuly");
		//		}
		//		else
		//		{
		//			Console.WriteLine("Insertion failed");
		//		}
		//	}
			
		//	con.Close();
		//}
		//public static void read()
		//{
		//	SqlConnection con = new SqlConnection(connectionString);
		//	con.Open();
		//	SqlCommand cmd;
		//	string query = "select * from Restaurant";
		//	cmd = new SqlCommand(query, con);
		//	SqlDataReader rd = cmd.ExecuteReader();
		//	while (rd.Read())
		//	{
		//		Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", rd[0], rd[1], rd[2],rd[3],rd[4]);
		//	}
  //      }
		public static Restaurant SetData()
		{
			Console.WriteLine("Enter the Name of the Restaurant");
			string resName = Console.ReadLine();
			Console.WriteLine("Enter the Timings");
			string resTimings = Console.ReadLine();
			Console.WriteLine("Enter the Location");
			string resLoc = Console.ReadLine();
			Console.WriteLine("Enter the Reg number");
			string resReg = Console.ReadLine();
			Console.WriteLine("Enter the Ratings");
			float resRating = float.Parse(Console.ReadLine());
			Restaurant res = new Restaurant();
			res.Name = resName;
			res.Timings = resTimings;
			res.location = resLoc;
			res.regnum = resReg;
			res.rating_out_Of_5 = resRating;
			return res;
		}
		static void Main(string[] args)
		{
			//insert("SukkuBhai","6Am to 10PM","Kandhanchavadi","RES123",3.5f);
			//insert("SalemRR", "5Am to 11PM", "Karapakkam", "RES001", 5);
			//read();
			//Restaurant rt = SetData();
			RestaturantData rd = new RestaturantData();
			//rd.addRes(rt);
			List<Restaurant> resLists=rd.showRestaurant();

			foreach(var li in resLists)
			{
				Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",li.Name,li.Timings,li.location,li.regnum,li.rating_out_Of_5);
			}
			Console.ReadKey();
			
		}
	}
}
