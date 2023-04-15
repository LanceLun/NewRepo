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
		//公司有人，有些人是員工
		//class person
		//class employee

		//員工有三種職位，本薪外領有不同種的工資
		//1. 工程師
		//class Engineer 領 overtimepay(加班費)

		//2. 業務
		//class Sales 領 bonus(紅利分潤)

		//3. 經理
		//class Manage 領 leaderBounus(領導加給)
		//--> leaderBonus 視 帶領的員工（Employee[] ）人數而定，領導一人10萬元

		//public CluSalary // 寫一個函數計算回傳所有人的薪資

		static void Main(string[] args)
		{
			try 
			{
				var employees = new List<Employee>() { new Employee("Toyota",false,102069,23000),
												   new Sales("BMW",true,099011,30000,50000),
												   new Engineer("Benz",true,081096,40000,60),
												   new Sales("Honda",false,095011,30000,100000),
												   new Engineer("Ford",false,081096,50000,100),};

				employees.Add(new Manage("Bentley", true, 075001, 80000,
							new Employee[] { employees[1], employees[2] }));

				CluSalary(employees.ToArray());
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex); 
			}
		}

		static void CluSalary(Employee[] employees) 
		{

			foreach (Employee e in employees) 
			{
				string gender = "";
				gender = e.Gender ? "男" : "女";
				string template = "員工：{0,-10}，員工編號{2,6}，性別：{1,-1}，薪水為：{3}";
				string result = string.Format(template, e.Name,gender, e.Id, e.GetSalary());
				Console.WriteLine(result);
			}
            
        }

		/// <summary>
		/// 人的基本資訊，姓名、性別
		/// </summary>
		class People
		{

			public string Name { get;private set ;}
            public bool Gender { get;private set; }
            public People(string name,bool gender)
            {
				if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException("姓名不得留空"); }
                this.Name = name;
				this.Gender = gender;
            }
			
		}

		/// <summary>
		/// 要有員編才是員工，基本薪資不得低於2.3萬
		/// </summary>
		class Employee :People
		{
			public int Id { get; private set; }
			private int BaseSalary;
            public Employee(string name, bool gender,int id,int baseSalary)
				:base(name,gender)
            {
				if (string.IsNullOrEmpty(id.ToString())) 
				{
					throw new ArgumentException("員工編號不能留空");
				}
				if (baseSalary < 23000) 
				{
					throw new Exception("基本薪資不得低於勞基法");
				}
				this.Id = id;
				this.BaseSalary = baseSalary;
			}
			public virtual int GetSalary() => BaseSalary;

        }

		/// <summary>
		/// 工程師領加班費
		/// </summary>
		class Engineer : Employee 
		{
            public int Overtime { get;private set; }
			private int HourPay;
			public Engineer(string name, bool gender, int id, int baseSalary, int overtime,int hourPay =300) : base(name, gender, id, baseSalary)
            {
				if (hourPay < 300) { throw new Exception("加班時薪不得低於300"); }
				if (overtime < 0) { throw new Exception("加班時數不得低於0"); }
                this.Overtime = overtime;
				this.HourPay = hourPay;
            }
			public override int GetSalary()=>base.GetSalary()+ Overtime* HourPay;
		}

		/// <summary>
		/// 業務-領底薪加業績%10，如果業績超過10W額外給bonus
		/// </summary>
		class Sales :Employee
		{
			private int Achievement;
			public Sales(string name, bool gender, int id, int baseSalary, int achievement) : base(name, gender, id, baseSalary)
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
					bonus= (int)Math.Round(((double)Achievement / 10), MidpointRounding.AwayFromZero);
					return base.GetSalary() + bonus;
				}
				 
			}
        }

		/// <summary>
		/// 經理領領導加給，視下屬有幾人而定，領導一人就加10W
		/// </summary>
		class Manage :Employee
		{
			private Employee[] Subordinates;
            public Manage(string name, bool gender, int id, int baseSalary,Employee[] subordinates)
				: base(name, gender, id, baseSalary)
			{
				this.Subordinates = subordinates;
            }
			public override int GetSalary()
			{
				int leaderBounus = 0;
				leaderBounus=  Subordinates.Count()*100000;
				return base.GetSalary() +leaderBounus;
			}
		}

	}

}
