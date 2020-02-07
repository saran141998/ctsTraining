using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GalleryApp
{
	public partial class ImageUpload : System.Web.UI.Page
	{
		void Page_PreRender()
		{
			string uploadFolder = MapPath("~/Resources/");
			DirectoryInfo dir = new DirectoryInfo(uploadFolder);
			DataList1.DataSource = dir.GetFiles();
			DataList1.DataBind();
		}


		protected void Page_Load(object sender, EventArgs e)
		{

			Label1.Visible = false;
			
		}
		


		bool CheckFileType(string fileName)
		{

			string ex = Path.GetExtension(fileName);
			switch (ex.ToLower())
			{

				case ".jpg":
					return true;
				case ".jpeg":
					return true;
				case ".png":
					return true;
				case ".gif":
					return true;
				default:
					return false;
			}

		}
		bool check_size(double size)
		{
			bool flag=true;
			if (size >625000)
			{
				flag = false;
			}

			return flag;
			

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

			Label1.Text = (FileUpload1.PostedFile.ContentLength).ToString();
			if (FileUpload1.HasFiles)
			{
				if (!check_size(Convert.ToDouble(FileUpload1.PostedFile.ContentLength)))
				{
					Label1.Visible = true;
					Label1.ForeColor = Color.Red;
					Label1.Text = "Please Upload the image file less than 5KB";
				}
				else if (CheckFileType(FileUpload1.FileName))
				{
					FileUpload1.SaveAs(MapPath("~/Resources/" + FileUpload1.FileName));
				}
				else
				{
					Label1.Visible = true;
					Label1.ForeColor = Color.Red;
					Label1.Text = "Please choose the following file formats: .jpg,.jpeg,gif,.png";
					
				}
			}
			else
			{
				Label1.Visible = true;
				Label1.ForeColor = Color.Red;
				Label1.Text = "Please choose any file to upload";
			}
		}
	}
}