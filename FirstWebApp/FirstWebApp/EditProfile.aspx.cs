using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
	public partial class EditProfile : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ButtonId_Click(object sender, EventArgs e)
		{
			ADOLayer al = new ADOLayer();
			al.update(Convert.ToInt32(Id.Text), NameId.Text.ToString());
		}
	}
}