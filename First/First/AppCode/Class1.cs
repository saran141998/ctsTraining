using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace First.AppCode
{
    public class Class1
    {
        SqlCommand cmd;
        SqlDataAdapter ad;
        Boolean flag;
        static  string connectionString = @"Data Source=BLT1049\SQLEXPRESS2014;Initial Catalog=signup;Integrated Security=True;";
        SqlConnection con = new SqlConnection(connectionString.ToString());

        public void conn()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
		public Boolean record_available(string query)
		{
			conn();
			con.Open();
			cmd = new SqlCommand(query, con);
			int count = Convert.ToInt32(cmd.ExecuteScalar());
			if (count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
       
    }
}