using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
	public partial class WebFormData : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!this.IsPostBack)
			{
				ADOLayer al = new ADOLayer();
				var list=al.getAllRecords();

				GridView1.DataSource = list;
				GridView1.DataBind();
			}
		}
	}
}