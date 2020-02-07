using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trainee
{
	public partial class TraineeData : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!this.IsPostBack)
			{
				TrainerDataLayer al = new TrainerDataLayer();
				var list = al.getAllRecords();

				trainerDataGrid.DataSource = list;
				trainerDataGrid.DataBind();
			}
		}
	}
}