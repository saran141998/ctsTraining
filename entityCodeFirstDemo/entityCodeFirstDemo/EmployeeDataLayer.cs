using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace entityCodeFirstDemo
{
	class EmployeeDataLayer:DbContext
	{
		public DbSet<Emploee> Employees { get; set; }
	}
}
