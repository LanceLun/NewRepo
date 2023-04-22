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




namespace 同學成績計算.Model
{

	public class SubjectScore: IComparable<SubjectScore>
	{
        public string Subject { get; set; }
        public int Score { get;private set; }

        public SubjectScore(string subject, int score)
        {
            if (string.IsNullOrWhiteSpace(subject))
            {
                throw new ArgumentNullException("科目不能空白");
            }
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException("分數登入錯誤");
            }
            Subject = subject;
            Score = score;
        }
        public override string ToString()
        {
            return $"{Subject}成績是：{Score}\t";
        }

		public int CompareTo(SubjectScore other)=>Score.CompareTo(other.Score);
		
       
	}
	
    public class SubjectsCollection
	{
		private readonly List<SubjectScore> _subjects ;
        public SubjectsCollection(List<SubjectScore> subjects)
        {
            this._subjects = new List<SubjectScore> (subjects);
		}

		public string GetSubjectsText()
		{
			if (_subjects.Count > 0)
			{
				return string.Join(", ", _subjects.Select(x => x.ToString()));
				//return _subjects.Select(x => x.ToString()).Aggregate((a, b) => a += "," + b);
			}
			else
			{
				return "沒有成績";
			}
		}
		public string GetMax()
		{
			var max = _subjects.Max();
			return max.ToString();

		}
		public string GetMin()
		{
			var min = _subjects.Min();
			return min.ToString();
		}
		public bool IsPass()
		{
			double avg = _subjects.Count > 0 ? _subjects.Average(x => x.Score) :  0;
			return avg >=60;

		}

	}

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
