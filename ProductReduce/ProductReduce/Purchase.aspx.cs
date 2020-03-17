using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductReduce
{
	public partial class Purchase : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			productsEntities pe = new productsEntities();
			var pros = pe.products;
			int id=Convert.ToInt32(TextBox1.Text.ToString());
			var ids = from p in pros where p.PId == id select p;
			foreach(var i in ids)
			{
				i.AvailableQuantity=i.AvailableQuantity-Convert.ToInt32(TextBox2.Text);
			}
			pe.SaveChanges();
		}
	}
}