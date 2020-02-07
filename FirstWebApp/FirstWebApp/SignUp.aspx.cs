using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace FirstWebApp
{
	public partial class SignUp : System.Web.UI.Page
	{
		string conString = ConfigurationManager.ConnectionStrings["cons"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonId_Click(object sender, EventArgs e)
		{
			SqlConLib cls = new SqlConLib();

			if (cls.record_available("select count(*) from signup where Email='" + EmaiID.Text + "' "))
			{
				Label1.Text = "Email Already Exists";
				ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Already Exists')", true);
			}
			else
			{
				ADOLayer al = new ADOLayer();
				al.insertRec(UsernameId.Text, EmaiID.Text, passwordId.Text);
			}
			
		}
	}
}