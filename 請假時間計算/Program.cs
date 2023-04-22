using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 請假時間計算
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Console.WriteLine("請輸入起始時間(格式：yyyy/MM/dd/HH/mm/ss)：");
			DateTime began = new DateTime(2023, 4, 22, 12, 30, 0);
			DateTime over = new DateTime(2023, 4, 22, 19, 30, 0);
			LeaveTime leave = new LeaveTime(began, over);
			TimeSpan leaveTime = leave.GetLeaveTime();
			Console.WriteLine($"實際請假時間為 {leaveTime.TotalHours} 小時");

		}

		public class LeaveTime
		{
			private TimeSpan leaveHour;
			private DateTime _workStart;
			private DateTime _workEnd;
			private DateTime _lunchStart;
			private DateTime _lunchEnd;
			private DateTime _start;
			private DateTime _end;
			public LeaveTime(DateTime start, DateTime end)
			{
				this._workStart = new DateTime(start.Year, start.Month, start.Day, 9, 0, 0);
				this._workEnd = new DateTime(start.Year, start.Month, start.Day, 18, 0, 0);
				this._lunchStart = new DateTime(start.Year, start.Month, start.Day, 12, 0, 0);
				this._lunchStart = new DateTime(start.Year, start.Month, start.Day, 13, 0, 0);
				if (start >= _workEnd || end <= _workStart)
				{
					throw new Exception("請假時間異常");
				}
				if ((int)start.DayOfWeek < 1 || (int)start.DayOfWeek > 5)
				{
					throw new Exception("六、日不用請假");
				}
				if (start < _workStart)
				{
					start = _workStart;
				}
				if (end > _workEnd)
				{
					end = _workEnd;
				}
				this._start = start;
				this._end = end;
			}

			public TimeSpan GetLeaveTime()
			{
				leaveHour = (_start - _end).Duration();
				if(_start.TimeOfDay<_lunchEnd.TimeOfDay && _end.TimeOfDay > _lunchStart.TimeOfDay)
				{
					leaveHour = (_start-_end).Duration().Subtract(_lunchEnd-_lunchStart).Duration();
				}
				return leaveHour;
			}


		}

	}



}
