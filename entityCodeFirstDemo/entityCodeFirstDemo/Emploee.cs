using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityCodeFirstDemo
{
	class Emploee
	{
		[Key]
		public int EmpId { get; set; }
		public string EmpName { get; set; }
		public string designation { get; set; }
		public double BasicSalary { get; set; }

	}
}
