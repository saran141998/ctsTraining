using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignUpRestrict
{
	public partial class SignUp : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			signupEntities signUpEn = new signupEntities();
			var signupData = signUpEn.signups;
			List<string> emails = new List<string>();
			foreach (var s in signupData)
			{
				emails.Add(s.Email);
			}
			if (emails.Contains(TextBox1.Text.ToString()))
			{
				Label1.Text = "Email Already Exists";
				ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Already Exists')", true);
			}

		}

	}
}