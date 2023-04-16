using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 該讀書喇同學_薪水計算
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try 
			{
				var employees = new List<Employee>() { new Employee("Toyota",false,"100069","emp",23000),
												   new Sales("BMW",true,"099011","sales",30000,50000),
												   new Engineer("Benz",true,"081096","ENGINEER",40000,60),
												   new Sales("Honda",false,"095011","SALES",30000,100000),
											   new Engineer("Ford",false,"081096","engineer",50000,100),};

				employees.Add(new Manager("Bentley", true, "075001","Manager", 80000,
							new Employee[] { employees[1], employees[2] }));

				CluSalary(employees);
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex); 
			}
		}

		static void CluSalary(List<Employee>employees) 
		{

			foreach (Employee e in employees) 
			{
				string gender = "";
				gender = e.Gender ? "男" : "女";
				string result = $"員工：{e.Name,-10}，員工編號：{e.Id,6}，性別：{gender,-1}，職位：{e.position,-10}，薪資為：{e.GetSalary()}";
				Console.WriteLine(result);
			}
            
        }
	}

}


namespace 該讀書喇同學_薪水計算
{
	/// <summary>
	/// 人的基本資訊，姓名、性別
	/// </summary>
	internal class People
	{
		public string Name { get; private set; }
		public bool Gender { get; private set; }
		public People(string name, bool gender)
		{
			if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException("姓名不得留空"); }
			this.Name = name;
			this.Gender = gender;
		}
	}

	internal class Employee:People
	{
		/// <summary>
		/// 要有id才是員工，並且加入職位區分薪水(限定職位輸入值)
		/// </summary>
		public string Id { get; private set; }
		public string position { get; private set; }
		private int BaseSalary;
		public Employee(string name, bool gender, string id, string position, int baseSalary)
			: base(name, gender)
		{
			if (string.IsNullOrEmpty(id))
			{
				throw new ArgumentException("員工編號不能留空");
			}
			if (baseSalary < 23000)
			{
				throw new Exception("基本薪資不得低於勞基法");
			}
			if (position.ToLower() == "sales" || position.ToLower() == "engineer" || position.ToLower() == "manager") 
			{
				this.position = position.ToLower();
			}
			else { this.position = "employee"; }
			this.Id = id;
			this.BaseSalary = baseSalary;
		}
		public virtual int GetSalary() => BaseSalary;
	}

	internal class Engineer:Employee
	{
		/// <summary>
		/// 工程師領加班費
		/// </summary>
		public int Overtime { get; private set; }
		private int HourPay;
		public Engineer(string name, bool gender, string id,string position, int baseSalary, int overtime, int hourPay = 300) : base(name, gender, id, position, baseSalary)
		{
			if (hourPay < 300) { throw new Exception("加班時薪不得低於300"); }
			if (overtime < 0) { throw new Exception("加班時數不得低於0"); }
			this.Overtime = overtime;
			this.HourPay = hourPay;
		}
		public override int GetSalary() => base.GetSalary() + Overtime * HourPay;
		
	}

	internal class Sales:Employee
	{
		/// <summary>
		/// 業務-領底薪加業績%10，如果業績超過10W額外給bonus
		/// </summary>
		private int Achievement;
		public Sales(string name, bool gender, string id, string position, int baseSalary, int achievement) : base(name, gender, id, position, baseSalary)
		{
			if (achievement < 0)
			{
				throw new Exception("業績沒有負數");
			}
			this.Achievement = achievement;
		}
		public override int GetSalary()
		{
			int bonus = 0;
			if (Achievement >= 100000)
			{
				bonus = (int)Math.Round(((double)Achievement / 10), MidpointRounding.AwayFromZero) + 10000;
				return base.GetSalary() + bonus;
			}
			else
			{
				bonus = (int)Math.Round(((double)Achievement / 10), MidpointRounding.AwayFromZero);
				return base.GetSalary() + bonus;
			}

		}
		
	}

	internal class Manager:Employee
	{
		/// <summary>
		/// 經理領領導加給，視下屬有幾人而定，領導一人就加10W
		/// </summary>
		private Employee[] Subordinates;
		public Manager(string name, bool gender, string id, string position, int baseSalary, Employee[] subordinates)
			: base(name, gender, id, position, baseSalary)
		{
			this.Subordinates = subordinates;
		}
		public override int GetSalary()
		{
			int leaderBounus = 0;
			leaderBounus = Subordinates.Count() * 100000;
			return base.GetSalary() + leaderBounus;
		}
	}
}