using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trainee
{
	public partial class InsertTrainee : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Label1.Visible = false;
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			TrainerDataLayer al = new TrainerDataLayer();
			string ee=al.insertRec(txtName.Text.ToString(), txtEmail.Text.ToString(),txtMobile.Text.ToString(), Convert.ToDateTime(trainerDob.Text.ToString()), txtDomain.Text.ToString());
			Label1.Visible = true;
			Label1.Text = ee;

		}
	}
}