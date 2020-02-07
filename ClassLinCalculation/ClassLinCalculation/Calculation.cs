using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibCalculation
{
    public class Calculation
    {
		public int num1 { get; set; }
		public int num2 { get; set; }
		public string add()
		{
			return string.Format("Sum={0}", num1 + num2);
		}
		public string difference()
		{
			return string.Format("Diff={0}", num1 - num2);
		}

    }
}
