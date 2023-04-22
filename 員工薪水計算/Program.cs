using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 員工薪水計算
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var employees = new List<Employee>() { new Sales("Toyota",false,"100069","emp",23000,10000),
												   new Sales("BMW",true,"099011","sales",30000,50000),
												   new Engineer("Benz",true,"081096","ENGINEER",40000,60),
												   new Sales("Honda",false,"095011","SALES",30000,100000),
											   new Engineer("Ford",false,"081096","engineer",50000,100)};

				employees.Add(new Manager("Bentley", true, "075001", "Manager", 80000,
							new Employee[] { employees[1], employees[2] }));

				CluSalary(employees);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}


		static void CluSalary(List<Employee> employees)
		{

			foreach (Employee e in employees)
			{

				string gender = "";
				gender = e.Gender ? "男" : "女";
				string result = $"員工：{e.Name,-10}，員工編號：{e.Id,6}，性別：{gender,-1}，職位：{e.Position,-10}，薪資為：{e.GetSalary(e.BaseSalary)}";
				Console.WriteLine(result);
			}

		}
	}
}
