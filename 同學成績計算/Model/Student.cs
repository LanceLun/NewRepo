using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 同學成績計算.Model
{
	public class Student
	{
        public string Name { get;private set; }
        public SubjectsCollection Subjects { get; private set; }
        public Student(string name,SubjectsCollection subjects)
        {
            this.Name = name;
            this.Subjects = subjects;
        }

        public void GetSubjectScoreMax() => Console.WriteLine($"最高分為科目為：{Subjects.GetMax()}");
        public void GetSubjectScoreMin() => Console.WriteLine($"最低分為科目為：{Subjects.GetMin()}");

        
        public void GetIsPass()
        {
			if (Subjects.IsPass())
			{
				Console.WriteLine("本次考試：通過");
			}
			else
			{
				Console.WriteLine("本次考試：不及格");
			}
		}
		public void GetInFo()
		{
            Console.WriteLine($"{Name}同學");
            Subjects.GetSubjectsText();
			GetSubjectScoreMax();
			GetSubjectScoreMin();
			GetIsPass();
		}
	}
}
