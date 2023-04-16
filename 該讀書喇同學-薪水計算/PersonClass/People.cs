using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
