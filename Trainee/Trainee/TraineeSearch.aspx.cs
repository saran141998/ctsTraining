using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trainee
{
	public partial class TraineeSearch : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			TrainerDataLayer al = new TrainerDataLayer();
			var list=al.search(Convert.ToInt32(searchId.Text));

			

			searchGrid.DataSource = list;
			searchGrid.DataBind();
		}
	}
}