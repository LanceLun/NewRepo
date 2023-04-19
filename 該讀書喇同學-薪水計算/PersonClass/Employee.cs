using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 該讀書喇同學_薪水計算
{
	
	internal abstract class Employee:People
	{
		/// <summary>
		/// 要有id才是員工，並且加入職位區分薪水(限定職位輸入值)
		/// </summary>
		public string Id { get;private set; }
		public string Position { get; private set; }
		public int BaseSalary { get; private set; }
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
				this.Position = position.ToLower();
			}
			else { this.Position = "employee"; }
			this.Id = id;
			this.BaseSalary = baseSalary;
		}
		public abstract int GetSalary(int baseSalary);
	}
}
