using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignupAndLogin
{
	public partial class Login : System.Web.UI.Page
	{

		public string curUser = "";
		states st = new states();
		
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string password = "";
			
			
			signupEntities sen = new signupEntities();
			var sd = sen.signups;
			var pass = from s in sd where s.Email == TextBox1.Text select s;
			foreach (var ss in pass)
			{
			 password= ss.pass.ToString();
			}
			
			List<string> emails = new List<string>();
			foreach (var s in sd)
			{
				emails.Add(s.Email);
			}
			if(emails.Contains(TextBox1.Text.ToString()) && password.Equals(TextBox2.Text.ToString()))
			{
				curUser = TextBox1.Text;
				var createLogin = new List<login>
			    {
					new login{ loginBy=TextBox1.Text.ToString()}
				};
				createLogin.ForEach(c => sen.logins.Add(c));
				sen.SaveChanges();
				var ld = sen.logins;
				var logs= from l in ld where l.loginBy == TextBox1.Text select l;
				foreach (var log in logs)
				{
					st.id = log.Id;

				}
				//Home h = new Home(st);
				Label1.Text = st.id.ToString();
				Response.Redirect("Home.aspx");
			}
			else
			{
				ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('user name not Exists')", true);
			}

		}
	}
}