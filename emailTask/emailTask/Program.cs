using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace emailTask
{
	class Program
	{
		static void Main(string[] args)
		{
			string sender = "dotnetbatch2019@gmail.com";
			string pass = "Dotnet123#";
			MailMessage mail = new MailMessage();
			mail.To.Add("sucharithareddy2017@gmail.com");
			mail.From = new MailAddress(sender, "DotNetMailServices", System.Text.Encoding.UTF8);
			mail.Subject = "Testing";
			mail.SubjectEncoding = System.Text.Encoding.UTF8;
			mail.Body = "Test Message body";
			mail.BodyEncoding = System.Text.Encoding.UTF8;
			mail.IsBodyHtml = true;
			mail.Priority = MailPriority.High;
			SmtpClient client = new SmtpClient();
			client.Credentials = new System.Net.NetworkCredential(sender, pass);
			client.Port = 587;
			client.Host = "smtp.gmail.com";
			client.EnableSsl = true;
			try
			{
				client.Send(mail);

			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				string errorMessage = string.Empty;
				while (ex2 != null)
				{
					errorMessage += ex2.ToString();
					ex2 = ex2.InnerException;
				}
				Console.WriteLine(ex2);
			}
			Console.ReadKey();
		}
		
	}
}
