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
			
			DateTime began = new DateTime(2023, 4, 19, 9,30,0);
			DateTime over = new DateTime(2023, 4, 19, 20, 30, 0);
			LeaveTime leave = new LeaveTime(began, over);
			TimeSpan leaveTime = leave.GetLeaveTime();
			Console.WriteLine($"實際請假時間為 {leaveTime.TotalHours} 小時");
		}

	}
	public class LeaveTime
	{
		private DateTime WorkStart;
		private DateTime WorkEnd;
		private DateTime LunchStart;
		private DateTime LunchEnd;
		private DateTime Began;
		private DateTime Over;

		public LeaveTime(DateTime began, DateTime over)
		{
			DateTime date= began.Date;
			this.WorkStart = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0);
			this.WorkEnd = new DateTime(date.Year, date.Month, date.Day, 18, 0, 0);
			this.LunchStart = new DateTime(date.Year, date.Month, date.Day, 12, 0, 0);
			this.LunchEnd = new DateTime(date.Year, date.Month, date.Day, 13, 0, 0);

			if (began >= WorkEnd || WorkStart >= over)
			{
				throw new Exception("請假起始時間，結束時間異常");
			}

			if (began < WorkStart)
			{
				began = WorkStart;
			}

			if (over > WorkEnd)
			{
				over = WorkEnd;
			}

			this.Began = new DateTime(began.Year, began.Month, began.Day, began.Hour, 0, 0);
			this.Over = new DateTime(over.Year, over.Month, over.Day, over.Hour, 0, 0);
		}

		public TimeSpan GetLeaveTime()
		{
			TimeSpan leaveTime = Over - Began;

			if (Began.TimeOfDay < LunchEnd.TimeOfDay && Over.TimeOfDay > LunchStart.TimeOfDay)
			{
				leaveTime = leaveTime.Subtract(LunchEnd - LunchStart);
			}

			return leaveTime;
		}
	}


}
