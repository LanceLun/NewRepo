using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int rows = 5;
			get(rows, x => new string('*', x*2-1).PadLeft(rows+x-1));

		}

		public static void get(int rows,Func<int,string> func)
		{
			for(int i = 1; i <= rows; i++)
			{
                Console.WriteLine(func(i));
			}
		}
	}
}
