using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C_練習
{
	internal class Program
	{
		static void Main(string[] args)
		{
		


			Func<int, int, string> leftTriangle = (row, rows) => new string('*', row);
			Func<int, int, string> rightTriangle = (row, rows) => new string('*', row).PadLeft(rows);
			Func<int, int, string> midTriangle = (row, rows) => new string('*', row*2-1).PadLeft(rows+row-1);
			Func<int, int, string> leftTriangledesc = (row, rows) => new string('*', rows-row+1);
			Func<int, int, string> rightTriangledesc = (row, rows) => new string('*', rows - row+1).PadLeft(rows);
			Func<int, int, string> midTriangledesc = (row, rows) => new string('*', rows * 2 - row*2+1).PadLeft(rows * 2 - row);



			int rows = 5;
			string result;
			//正
			//result=GetTriangle(rows, leftTriangle);
			//Console.WriteLine(result);

			//result = GetTriangle(rows, rightTriangle);
			//Console.WriteLine(result);

			//result = GetTriangle(rows, midTriangle);
			//Console.WriteLine(result);

			//反
			result = GetTriangle(rows, leftTriangledesc);
			Console.WriteLine(result);

			result = GetTriangle(rows, rightTriangledesc);
			Console.WriteLine(result);

			result = GetTriangle(rows, midTriangledesc);
			Console.WriteLine(result);


			string GetTriangle(int rows, Func<int, int, string> func)
			{
				var result = new StringBuilder();
				for (int i = 1; i <= rows; i++)
				{
					result.AppendLine(func(i, rows));
				}
				return result.ToString();
			}
		}
	}
}

	
