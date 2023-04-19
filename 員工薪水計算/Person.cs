using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace 員工薪水計算
{
	internal class Person
	{
		public string Name { get; private set; }
		public bool Gender { get; private set; }
		public Person(string name, bool gender)
		{
			if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException("姓名不得留空"); }
			this.Name = name;
			this.Gender = gender;
		}
	}
}
