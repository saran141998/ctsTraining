using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertAndSelect
{
	class RestaturantData
	{
		string connectionString;
		public RestaturantData()
		{
			 connectionString = @"Data Source=BLT1049\SQLEXPRESS2014;Initial Catalog=signup;Integrated Security=True;";
		}
		public void addRes(Restaurant rt)
		{
			string query = string.Format("insert into Restaurant(Name,Timings,location,regnum,rating_out_Of_5) values('{0}','{1}','{2}','{3}',{4})",rt.Name,rt.Timings,rt.location,rt.regnum,rt.rating_out_Of_5);
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd;
			con.Open();
			cmd = new SqlCommand(query,con);
			int i=cmd.ExecuteNonQuery();
			if (i > 0)
			{
				Console.WriteLine("Restaurant inserted succesfuly");
			}
			else
			{
				Console.WriteLine("Error");
			}
		}
		public List<Restaurant> showRestaurant()
		{
			var resList = new List<Restaurant>();
			string getQuery = "select * from Restaurant";
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd;
			con.Open();
			cmd = new SqlCommand(getQuery, con);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				resList.Add(new Restaurant{ Name=dr[0].ToString(),Timings=dr[1].ToString(),location=dr[2].ToString(),regnum=dr[3].ToString(),rating_out_Of_5=Convert.ToDouble(dr[4])});
			}
			return resList;
		}
	}
}
