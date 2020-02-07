using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using First.AppCode;
using SqlConnectionLibrary;

namespace First
{
    public partial class signUp : System.Web.UI.Page
    {
		SqlConLib cls = new SqlConLib();
        string connectionString = @"Data Source=BLT1049\SQLEXPRESS2014;Initial Catalog=signup;Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            if(cls.record_available("select count(*) from signup where email='" + EmaiID.Text+"' "))
			{
				Label1.Text = "Email Already Exists";
				ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Already Exists')", true);
			}
			else
			{
				cmd = new SqlCommand("insert into signup values('" + UsernameId.Text + "','" + EmaiID.Text + "','" + passwordId.Text + "')", con);
			    int status = cmd.ExecuteNonQuery();
			    Label1.Text = status.ToString();
			}
        }
    }
}