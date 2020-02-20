using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efCodeFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			do
			{
				Console.WriteLine("Enter Option");
				Console.WriteLine("1.Insert 2.Update 3.ShowAll 4.Search");
				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						insertData();
						break;
					case 2:
						updateEmp();
						break;
					case 3:
						showData();
						break;
					case 4:
						searchEmployee();
						break;
					default:
						Console.WriteLine("Please choose available options");
						break;
				}
				Console.WriteLine("Do you want to Continue 1.Yes 2.No");
				n = int.Parse(Console.ReadLine());
			} while (n == 1);


			Console.ReadKey();

		}

		private static void updateEmp()
		{
			EmployeeDataLayer el = new EmployeeDataLayer();
			var employees = el.Employees;
			Console.WriteLine("Enter emp Id");
			int id = int.Parse(Console.ReadLine());
			if (checkIdEmpExists(id))
			{
				Console.WriteLine("Select a Column to update 1.Salary 2.Designation");
				int op = int.Parse(Console.ReadLine());
				switch (op)
				{
					case 1:
						Console.WriteLine("Enter new Salary");
						double sal = double.Parse(Console.ReadLine());
						foreach (var emp in (from a in employees where a.EmpId == id select a))
						{
							emp.BasicSalary = sal;
						}
						el.SaveChanges();
						break;
					case 2:
						Console.WriteLine("Enter designation");
						string des = Console.ReadLine();
						foreach (var emp in (from a in employees where a.EmpId == id select a))
						{
							emp.designation = des;
						}
						el.SaveChanges();
						break;
					default:
						Console.WriteLine("Please choose the correct option to update");
						break;
				}
			}	
		}
		private static void searchEmployee()
		{
			Console.WriteLine("Enter Emp Id to search");
			int id = int.Parse(Console.ReadLine());
			if (checkIdEmpExists(id))
			{
				EmployeeDataLayer el = new EmployeeDataLayer();
				var employees = el.Employees.ToList();
				var employee = from a in employees where a.EmpId == id select a;
				foreach (var emp in employee)
				{
					Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.EmpId, emp.EmpName, emp.designation, emp.BasicSalary);
				}
			}
			
		}
		private static void showData()
		{
			EmployeeDataLayer el = new EmployeeDataLayer();
			var employees = el.Employees;
			foreach (var emp in employees)
			{
				Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.EmpId, emp.EmpName, emp.designation, emp.BasicSalary);
			}
		}

		private static void insertData()
		{
			EmployeeDataLayer el = new EmployeeDataLayer();
			Console.WriteLine("Enter Name");
			string name = Console.ReadLine();
			Console.WriteLine("Designation");
			string desig = Console.ReadLine();
			Console.WriteLine("Enter Basic Sal");
			double basicSal = Convert.ToDouble(Console.ReadLine());
			el.Employees.Add(new Employee
			{
				EmpName = name,
				designation = desig,
				BasicSalary = basicSal
			});
			el.SaveChanges();
		}
		private static bool checkIdEmpExists(int id)
		{
			EmployeeDataLayer el = new EmployeeDataLayer();
			var employees = el.Employees.ToList();
			var ids = from a in employees select a.EmpId;
			if (ids.Contains(id))
			{
				
				return true;
			}
			else
			{
				Console.WriteLine("No Id Found");
				return false;
			}
		}
	}
}
