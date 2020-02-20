using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace examAutomation
{
	class Program
	{
		
		static ExamAutomationSystemContainer ea = new ExamAutomationSystemContainer();
		static void Main(string[] args)
		{
			//createExams();
			//crateStudents();
			createMarks();
			Console.ReadKey();

		}

		private static void createMarks()
		{
			//var marks = new List<ResultInfo>
			//{
			//	new ResultInfo{ StudentRegNo=1,SubjectCode=1,Marks=95 },
			//	new ResultInfo{ StudentRegNo=1,SubjectCode=2,Marks=93 },
			//	new ResultInfo{ StudentRegNo=1,SubjectCode=3,Marks=92 },
			//	new ResultInfo{ StudentRegNo=1,SubjectCode=4,Marks=95 },
			//	new ResultInfo{ StudentRegNo=2,SubjectCode=1,Marks=91 },
			//	new ResultInfo{ StudentRegNo=2,SubjectCode=2,Marks=93 },
			//	new ResultInfo{ StudentRegNo=2,SubjectCode=3,Marks=89 },
			//	new ResultInfo{ StudentRegNo=2,SubjectCode=4,Marks=92 }


			//};
			//marks.ForEach(m => ea.ResultsInfo.Add(m));
			//ea.SaveChanges();
			Console.WriteLine("Enter the student id to get the Result");
			int id = int.Parse(Console.ReadLine());
			var results = ea.ResultsInfo;
			double x = (from subMarks in results where subMarks.StudentRegNo == id select subMarks.Marks).Sum();

			Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}", "SubjectCode", "StudentRegNo", "StudentName", "Marks");
			string body = "<font>Result: </font><br><br>";
			string htmlTableStart = "<table align=\"center\" style=\"border-collapse:collapse; text-align:center;\" >";
			string htmlTableEnd = "</table>";
			string htmlHeaderRowStart = "<tr style =\"background-color:#6FA1D2; color:#ffffff;\">";
			string htmlHeaderRowEnd = "</tr>";
			string htmlTrStart = "<tr style =\"color:#555555;\">";
			string htmlTrEnd = "</tr>";
			string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
			string htmlTdEnd = "</td>";
			body += htmlTableStart;
			body += htmlHeaderRowStart;
			body += htmlTdStart + "Subject" + htmlTdEnd;
			body += htmlTdStart + "Marks" + htmlTdEnd;
			body += htmlHeaderRowEnd;
			foreach (var r in from rs in results where rs.StudentRegNo == id select rs)
			{
				Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-19}", r.SubjectCode, r.StudentRegNo, r.StudentInfo.StudentName, r.Marks);
				body += htmlTrStart;
				body += htmlTdStart + r.ExamInfo.SubjectName + htmlTdEnd;
				body += htmlTdStart + r.Marks + htmlTdEnd;
				body += htmlTrEnd;

				
			}
			body += htmlTableEnd;
			mailService(body);
			if (x > 175)
			{
				Console.WriteLine("Pass ,Total={0}", x);
			}
			

		}

		private static void mailService(string msg)
		{
			string @from = "saravanansr98@gmail.com";
			string pass1 = "Helloworld123@mail";
			MailMessage mail = new MailMessage();
			mail.To.Add("sucharithareddy2017@gmail.com");
			mail.From = new MailAddress(@from, "Could Mail Service", System.Text.Encoding.UTF8);
			mail.Subject = "Result";
			mail.SubjectEncoding = System.Text.Encoding.UTF8;
			mail.Body = msg;
			mail.BodyEncoding = System.Text.Encoding.UTF8;
			mail.IsBodyHtml = true;
			mail.Priority = MailPriority.High;
			SmtpClient client = new SmtpClient();
			client.Credentials = new System.Net.NetworkCredential(@from, pass1);

			client.Port = 587;
			// Gmail works on this port
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
		}

		private static void crateStudents()
		{
			var students = new List<StudentInfo>
			{
				new StudentInfo{ SchoolName="Abc",StudentName="Saravanan",DOB=Convert.ToDateTime("1998-07-14")},
				new StudentInfo{SchoolName="Amc",StudentName="Rohith",DOB=Convert.ToDateTime("1997-06-22")},
			};
			students.ForEach(s => ea.StudentsInfo.Add(s));
			ea.SaveChanges();
		}

		private static void createExams()
		{
			var exams = new List<ExamInfo>
			{
				new ExamInfo{ SubjectCode=1,SubjectName="English",Examdate=Convert.ToDateTime("2020-02-24")},
				new ExamInfo{ SubjectCode=2,SubjectName="Maths",Examdate=Convert.ToDateTime("2020-02-26")},
				new ExamInfo{ SubjectCode=3,SubjectName="Science",Examdate=Convert.ToDateTime("2020-02-28")},
				new ExamInfo{ SubjectCode=4,SubjectName="Social;",Examdate=Convert.ToDateTime("2020-03-02")},

			};
			exams.ForEach(e => ea.ExamsInfo.Add(e));
			ea.SaveChanges();
		}
	}
}
