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
   //         result=GetTriangle(1, leftTriangle);
   //         Console.WriteLine(result);

			//result = GetTriangle(1, rightTriangle);
			//Console.WriteLine(result);

			//result = GetTriangle(1, midTriangle);
			//Console.WriteLine(result);

			//反
			result = GetTriangle(1, leftTriangledesc);
			Console.WriteLine(result);

			result = GetTriangle(1, rightTriangledesc);
			Console.WriteLine(result);

			result = GetTriangle(1, midTriangledesc);
			Console.WriteLine(result);


			string GetTriangle(int row, Func<int, int, string> func)
			{
				var result = new StringBuilder();
				for (int i = row; i <= rows; i++)
				{
					result.AppendLine(func(i, rows));
				}
				return result.ToString();
			}
		}
	}
}

	
