using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListSort
{
	class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	class Program
	{
		public static List<Student> listDemo(List<Student> sl)
		{
			return (from stu in sl orderby stu.Id select stu).ToList();
		}
		static void Main(string[] args)
		{

			List < Student > stuList= new List<Student>()
			{
				new Student{ Id=2,Name="Saravanan"},
				new Student{ Id=1,Name="Kohli"}
			};
			var stuget = listDemo(stuList);
			foreach(var stu in stuget)
			{
				Console.WriteLine("{0}\t{1}",stu.Id,stu.Name);
			}
			Console.ReadKey();
		}
	}
}
