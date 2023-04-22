using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 同學成績計算.Model
{

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
}
