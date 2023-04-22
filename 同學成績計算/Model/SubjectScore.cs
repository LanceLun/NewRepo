using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	

}
