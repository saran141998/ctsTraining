﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace efCodeFirst
{
	class Employee
	{
		[Key]
		public int EmpId { get; set; }
		public string EmpName { get; set; }
		public string designation { get; set; }
		public double BasicSalary { get; set; }
	}
}
