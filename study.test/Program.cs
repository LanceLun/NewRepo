using System;
using System.Collections.Generic;
using System.ComponentModel;
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

			//Func<int, int, string> left = (row, rows) => new string('*', row);
			//Func<int, int, string> right = (row, rows) => new string('*', row).PadLeft(rows);
			//Func<int, int, string> mid = (row, rows) => new string('*', row * 2 - 1).PadLeft(row + rows - 1);

			//Get(1, 5, left, right, mid);



			Func<int, int, string> turnoverleft = (row, rows) => new string('*', row);
			Func<int, int, string> turnoverright = (row, rows) => new string('*', row).PadLeft(rows);
			Func<int, int, string> turnovermid = (row, rows) => new string('*', row * 2 - 1).PadLeft(rows + row - 1);
			GetTurnover(1, 5, turnoverleft, turnoverright, turnovermid);

		}

		public static void GetTurnover(int row,int rows, Func<int, int, string> turnoverleft, Func<int, int, string> turnoverright, Func<int, int, string> turnovermid)
		{
			for (int i = rows; i > 0; i--)
			{
				Console.WriteLine(turnoverleft(i, rows));
			}
			for (int i = rows; i > 0; i--)
			{
				Console.WriteLine(turnoverright(i, rows));
			}
			for (int i = rows; i > 0; i--)
			{
				Console.WriteLine(turnovermid(i, rows));
			}
		}

		public static void Get(int row, int rows, Func<int, int, string> left, Func<int, int, string> right, Func<int, int, string> mid)
		{
			for (int i = 1; i <= rows; i++)
			{
				Console.WriteLine(left(i, rows));
			}
			for (int i = 1; i <= rows; i++)
			{
				Console.WriteLine(right(i, rows));
			}
			for (int i = 1; i <= rows; i++)
			{
				Console.WriteLine(mid(i, rows));
			}
		}


	}
	
}
