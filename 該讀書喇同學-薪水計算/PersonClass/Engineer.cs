using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 該讀書喇同學_薪水計算
{
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
		public override int GetSalary(int baseSalary) =>  baseSalary + Overtime * HourPay;
		
	}
}
