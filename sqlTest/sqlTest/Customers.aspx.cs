
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace sqlTest
{
	public partial class Customers : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string con = ConfigurationManager.ConnectionStrings["cons"].ConnectionString;
			SqlConnection cs = new SqlConnection(con);
			SqlCommand cmd = new SqlCommand("select * from Employee where EmpName like '" + searchId.Text + "%'", cs);
			cs.Open();
			cusData.DataSource = cmd.ExecuteReader();
			cusData.DataBind();
			cs.Close();

		}
	}
}