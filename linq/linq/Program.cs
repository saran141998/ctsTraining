using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
	class course
	{
		public int Id { get; set; }
		public string CourseName { get; set; }
		public double fee { get; set; }
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
	}
    class Program
    {
        static void Main(string[] args)
        {
			List<course> c = new List<course>()
			{
				new course{ Id=101,CourseName="Java",fee=10000,startDate=Convert.ToDateTime("12/21/2020"),endDate=Convert.ToDateTime("06/21/2021")},
				new course{ Id=102,CourseName="J2EE",fee=12000,startDate=Convert.ToDateTime("01/21/2020"),endDate=Convert.ToDateTime("06/21/2020")},

			};

			DateTime d = new DateTime(2020, 06, 01);
		
			//int[] a = { 5, 4, 1, 7, 6, 3, 2 };

			//var q = a.OrderBy(x => x);
			//Console.Write(string.Join(" ", q));
			var qget = from a in c orderby a.fee select a;
			foreach(var q in qget)
			{
				Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",q.Id,q.CourseName,q.fee,q.startDate,q.endDate);
			}
			Console.ReadKey();
        }
    }
}
