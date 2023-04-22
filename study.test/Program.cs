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
			int rows = 5;
			Func<int, string> left = q => new string('*', q);
			Func<int, string> right = w => new string('*', w).PadLeft(rows);
			Func<int, string> mid = a => new string('*', a * 2 - 1).PadLeft(a + rows - 1);

			Get(rows,left,right,mid);

			GetTurnover(rows, left,right,mid);

		}

		public static void GetTurnover(int rows, Func<int, string> left ,Func<int, string> right, Func<int, string> mid)
		{
			for(int i=rows; i > 0; i--)
			{
				Console.WriteLine(left(i));
			}
			for (int i = rows; i > 0; i--)
			{
				Console.WriteLine(right(i));
			}
			for (int i = rows; i > 0; i--)
			{
				Console.WriteLine(mid(i));
			}
		}

		public static void Get(int rows,Func<int,string>left, Func<int, string> right, Func<int, string> mid)
		{
			for(int i = 1; i <= rows; i++)
			{
				Console.WriteLine(left(i));
			}
			for(int i = 1;i <= rows; i++)
			{
				Console.WriteLine(right(i));
			}
			for (int i = 1; i <= rows; i++)
			{
				Console.WriteLine(mid(i));
			}
		}
		
		
	}
	
}
