using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Trainee
{
	public class TrainerDataLayer
	{
		DataSet ds = new DataSet();
		string conString;
		public TrainerDataLayer()
		{
			conString= ConfigurationManager.ConnectionStrings["cons"].ConnectionString;
		}
		public DataSet getAllRecords()
		{
			try
			{
				SqlConnection con = new SqlConnection(conString);

				SqlCommand cmd=new SqlCommand();

				cmd.CommandText = "getAll";
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Connection = con;
				SqlDataAdapter da = new SqlDataAdapter(cmd);

				da.Fill(ds);

			}
			catch (Exception ex)
			{

			}
			return ds;
		}
		public DataSet search(int id)
		{
			try
			{
				SqlConnection con = new SqlConnection(conString);

				SqlCommand cmd = new SqlCommand();
				cmd.Parameters.AddWithValue("@TraineeId", id);
				cmd.CommandText = "search";
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Connection = con;
				SqlDataAdapter da = new SqlDataAdapter(cmd);

				da.Fill(ds);

			}
			catch (Exception ex)
			{

			}
			return ds;
		}
		public string insertRec(string name, string email, string mobile,DateTime dob,string domain)
		{

			string e = "";

			try
			{
				SqlConnection con = new SqlConnection(conString);

				SqlCommand cmd = new SqlCommand();

				cmd.Parameters.AddWithValue("@Name", name);
				cmd.Parameters.AddWithValue("@Email", email);
				cmd.Parameters.AddWithValue("@Mobile", mobile);
				cmd.Parameters.AddWithValue("@DOB", dob);
				cmd.Parameters.AddWithValue("@Domain", domain);
				cmd.CommandText = "insertRec";
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Connection = con;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(ds);
				da.Update(ds);
			}
			catch (Exception ex)
			{
			 e = ex.Message;
			}

			return e;

		}

		public void update(int id, string domain)
		{
			try
			{
				SqlConnection con = new SqlConnection(conString);

				SqlCommand cmd = new SqlCommand();

				cmd.Parameters.AddWithValue("@TraineeId", id);
				cmd.Parameters.AddWithValue("@Domain",domain);
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