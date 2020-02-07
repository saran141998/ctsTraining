using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trainee
{
	public partial class EditTrainee : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			TrainerDataLayer al = new TrainerDataLayer();

			al.update(Convert.ToInt32(txtId.Text),txtDomain.Text.ToString());
		}
	}
}