using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 成績計算
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var apple = new Student("Apple", new SubjectScore[]
			{new SubjectScore("國文",50),
			new SubjectScore("英文", 40),
			new SubjectScore("數學",96) });

			var banana = new Student("Banana", new SubjectScore[]
			{new SubjectScore("地理",20),
			new SubjectScore("歷史", 80),
			new SubjectScore("化學",10) });

			apple.GetInFo();
			banana.GetInFo();

		}
	}

	public class SubjectScore : IComparable<SubjectScore>
	{
		public string Subject { get; private set; }
		public int Score { get; private set; }
		public SubjectScore(string subject, int score)
		{
			if (string.IsNullOrWhiteSpace(subject))
			{
				throw new ArgumentNullException("科目不得留空");
			}
			if (score < 0 || score > 100)
			{
				throw new ArgumentOutOfRangeException("分數需介於0~100");
			}
			this.Subject = subject;
			this.Score = score;
		}
		public int CompareTo(SubjectScore other)
		{
			return Score.CompareTo(other.Score);
		}

		public string GetSubjectScore()
		{
			return $"{Subject},分數為：{Score}";
		}

	}

	public class Student
	{
		public string Name { get; private set; }
		private List<SubjectScore> _subjects;
		public Student(string name, SubjectScore[] subjects)
		{
			this.Name = name;
			this._subjects = subjects.OrderBy(X => X.Score).ToList();


		}

		public string GetGetSubjectScoreList()
		{
			string result = _subjects.Count > 0 ? string.Join(" ,", _subjects.Select(x => x.GetSubjectScore())) : "沒有成績";
			return result;

		}
		public void GetMaxScore() => Console.WriteLine($"最高分為：{_subjects.Max(x => x.Score)}");

		public void GetMinScore() => Console.WriteLine($"最低分為：{_subjects.Min(x => x.Score)}");

		public void GetAvgScore() => Console.WriteLine($"平均分數為：{_subjects.Average(x => x.Score):F2}");

		public void GetAddScore() => Console.WriteLine($"總分為：{_subjects.Sum(x => x.Score)}");


		public void GetInFo()
		{
			Console.WriteLine($"{Name}, {GetGetSubjectScoreList()}");
			GetAddScore();
			GetAvgScore();
			GetMaxScore();
			GetMinScore();
			Console.WriteLine("--------------------------------------------------------");

		}

	}

}
