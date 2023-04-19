using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 員工薪水計算
{
	internal class Manager : Employee
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
		public override int GetSalary(int baseSalary)
		{
			int leaderBounus = 0;
			leaderBounus = Subordinates.Count() * 100000;
			return baseSalary + leaderBounus;
		}
	}
}
