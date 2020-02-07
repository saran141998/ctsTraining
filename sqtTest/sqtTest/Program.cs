using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sqtTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string connectionString = @"Data Source=BLT1049\SQLEXPRESS2014;Initial Catalog=signup;Integrated Security=True;";
			SqlConnection con = new SqlConnection(connectionString);
			con.Open();
			SqlCommand cmd;
			string query = "select * from signup";
			cmd = new SqlCommand(query,con);
			SqlDataReader rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				Console.WriteLine("{0}\t{1}\t{2}", rd[0], rd[1], rd[2]);
			}
			con.Close();
			Console.ReadKey();

		}
	}
}
