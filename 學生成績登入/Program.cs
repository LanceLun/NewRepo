using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 學生成績登入
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var apple = new Student("Apple", new SubjectCollen(new SubjectScore[] {
			new SubjectScore("國文",50),
			new SubjectScore("英文", 40),
			new SubjectScore("數學",96)}));

			var banana = new Student("Banana", new SubjectCollen(new SubjectScore[] {
			new SubjectScore("國文",50),
			new SubjectScore("物理", 10),
			new SubjectScore("歷史",30)}));


			apple.GetInfo();
			banana.GetInfo();

		}
	}


	/// <summary>
	/// 單一科目及分數，實作IComparable排序
	/// </summary>
	public class SubjectScore:IComparable<SubjectScore>
	{
		private string _subject;
        public int Score { get; set; }
        public SubjectScore(string subject,int score)
        {
			if (string.IsNullOrWhiteSpace(subject))
			{
				throw new ArgumentNullException("科目必填");
			}
			if (score < 0 || score > 100)
			{
				throw new ArgumentOutOfRangeException("分數需介於0~100");
			}
			_subject = subject;
			Score = score;
        }

		public int CompareTo(SubjectScore other)
		{
			return Score.CompareTo(other.Score);
		}
		public string GetSubjectScore()
		{
			return $"{_subject}分數為：{Score}";
		}
	}


	/// <summary>
	/// 放多科成績跟科目
	/// </summary>
	public class SubjectCollen
	{
		private readonly List<SubjectScore> _subject;
        public SubjectCollen(SubjectScore[] subject)
        {
			_subject =subject.ToList();
        }

		//將多科成績分數列出
		public string GetSubjectScoreInFo()
		{
			string result=_subject.Count() > 0 ? string.Join("  ,", _subject.Select(x => x.GetSubjectScore())) : "沒有成績";
            return result;
        }

		//秀出分數最高分的科目
		public void GetMaxScore() => Console.WriteLine(_subject.Max(x=> $"最高分{x.GetSubjectScore()}"));

		//秀出分數最低分的科目
		public void GetMinScore() => Console.WriteLine(_subject.Min(x => $"最低分{x.GetSubjectScore()}"));
		public bool IsPass()
		{
			double avg= _subject.Average(x=> x.Score);
			return avg >= 60;
		}

	}

	public class Student
	{
        public string Name { get;private set; }
		private SubjectCollen _subjectCollen;
        public Student(string name, SubjectCollen subjectCollen)
        {
            this.Name = name;
			_subjectCollen = subjectCollen;
        }

		//判斷是否合格
		public void GetIsPass()
		{
			string result = _subjectCollen.IsPass() ? "本次考試及格" : "本次考試不及格";
            Console.WriteLine(result);

        }


		//呼叫
		public void GetInfo()
		{
			string result=$"{Name}同學，{_subjectCollen.GetSubjectScoreInFo()}";
            Console.WriteLine(result);
            _subjectCollen.GetMaxScore();
			_subjectCollen.GetMinScore();
			GetIsPass();
            Console.WriteLine("--------------------------------------------------------------------");
        }

    }


}
