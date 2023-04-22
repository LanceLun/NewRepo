using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 同學成績計算.Model;

namespace 同學成績計算
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var apple = new Student("Apple",new SubjectsCollection(new List<SubjectScore> 
			{
			new SubjectScore( "國文", 60 ),
			new SubjectScore("英文",40),
			new SubjectScore("數學",80)
			}));

			apple.GetInFo();

		}
	}
}
