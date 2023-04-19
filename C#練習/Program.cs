using System.Drawing;

namespace C_練習
{
	internal class Program
	{
		//DrawLeftTriangle
		static void Main(string[] args)
		{

		
			GetLeftTriangle(5, row => new string('*', row ));
			GetRightTriangle(5, row => new string('*', row));
			GetMidTriangle(5, row => new string('*', row*2-1));

		}
		public static void GetLeftTriangle(int rows, Func<int, string> triangle)
		{
			for (int row = 1; row <= rows; row++)
			{
				Console.WriteLine(triangle(row));
			}
		}
		public static void GetRightTriangle(int rows, Func<int, string> triangle)
		{
			for (int row = 1; row <= rows; row++)
			{
				Console.WriteLine(triangle(row).PadLeft(rows));
			}
		}
		public static void GetMidTriangle(int rows, Func<int, string> triangle)
		{
			for (int row = 1; row <= rows; row++)
			{
				Console.WriteLine(triangle(row).PadLeft(row+rows-1));
			}
		}
	}
}

	
