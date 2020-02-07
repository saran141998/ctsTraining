using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace FirstWebApp
{
	public class ADOLayer
	{
		DataSet ds = new DataSet();
		string conString;
		public ADOLayer()
		{
			conString = ConfigurationManager.ConnectionStrings["cons"].ConnectionString;
		}
		public DataSet getAllRecords()
		{
			

			try
			{
				SqlConnection con = new SqlConnection(conString);

				SqlCommand cmd;

				string query = "select * from signup";

				cmd = new SqlCommand(query, con);

				SqlDataAdapter da = new SqlDataAdapter(cmd);

				da.Fill(ds);
			    
			}
			catch(Exception ex)
			{

			}

			return ds;
		}
		public void insertRec(string name,string email,string pass)
		{
			
			try
			{
				SqlConnection con = new SqlConnection(conString);

				SqlCommand cmd = new SqlCommand();

				cmd.Parameters.AddWithValue("@Name", name);
				cmd.Parameters.AddWithValue("@Email", email);
				cmd.Parameters.AddWithValue("@pass", pass);
				cmd.CommandText = "insertRec";
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Connection = con;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(ds);
				da.Update(ds);
			}
			catch(Exception ex)
			{

			}


			
		}
		public void update(int id,string name)
		{
			try
			{
				SqlConnection con = new SqlConnection(conString);

				SqlCommand cmd = new SqlCommand();

				cmd.Parameters.AddWithValue("@ID", id);
				cmd.Parameters.AddWithValue("@Name", name);
				cmd.CommandText = "updateRec";
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Connection = con;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(ds);
				da.Update(ds);

			}
			catch (Exception ex)
			{

			}
		}
	}
}