using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study.test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime began = new DateTime(2023, 4, 19, 9, 30, 0);
			DateTime over = new DateTime(2023, 4, 19, 20, 30, 0);
			LeaveTime leave = new LeaveTime(began, over);
			TimeSpan leaveTime = leave.GetLeaveTime();
			Console.WriteLine($"實際請假時間為 {leaveTime.TotalHours} 小時");

		}
		
		
	}
	public class LeaveTime
	{
		private DateTime Start;
		private DateTime End;
		private DateTime WorkBegan;
		private DateTime WorkEnd;
		private DateTime LunchStart;
		private DateTime LunchEnd;

        public LeaveTime(DateTime start,DateTime end)
        {
			DateTime date= start.Date;
			WorkBegan = new DateTime(date.Year, date.Month, date.Day,9,0,0);
			WorkEnd = new DateTime(date.Year,date.Month,date.Day,18,0,0);
			LunchStart= new DateTime(date.Year, date.Month, date.Day,12,0,0);
			LunchEnd = new DateTime(date.Year, date.Month, date.Day, 13, 0, 0);
			if (start >= WorkEnd || end <= WorkBegan)
			{
				throw new Exception("時間異常");
			}
			if (start < WorkBegan) { start = WorkBegan; }
			if (end > WorkEnd) { end = WorkEnd; }

			this.Start = start;
			this.End = end;
		}
		public TimeSpan GetLeaveTime()
		{
			TimeSpan result=End - Start;

			if(Start.TimeOfDay<LunchEnd.TimeOfDay && End.TimeOfDay > LunchStart.TimeOfDay)
			{
				result = result.Subtract(LunchEnd- LunchStart);
			}
			return result;
		}
    }
	
}
