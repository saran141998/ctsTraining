using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SignupAndLogin
{
	public partial class Home : System.Web.UI.Page
	{
		states nst;
		//public Home(states st)
		//{
		//	this.nst = st;
		//}
		public void setObject(states st)
		{
			this.nst = st;
		}

		
		protected void Page_Load(object sender, EventArgs e)
		{
		
	
		}
		
		protected void Button1_Click(object sender, EventArgs e)
		{
			signupEntities sen = new signupEntities();
			var loginData = sen.logins;
			login log = sen.logins.Find(nst.id);
			sen.logins.Remove(log);
			sen.SaveChanges();
			Response.Redirect("Login.aspx");
		}
	}
}