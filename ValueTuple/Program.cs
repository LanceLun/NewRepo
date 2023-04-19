using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple
{   
	internal class Program
	{
		static void Main(string[] args)
		{
			//只能當成class的物件簡易創建，沒有method等其他功能
			var test = (1, "QQ");
            Console.WriteLine(test.Item1);
			Console.WriteLine(test.Item2);

			(string, int) test2 = ("VVV", 5);
            Console.WriteLine(test2.Item1);
			Console.WriteLine(test2.Item2);

			(int id, string name) test3 = (9, "HHHH");
			Console.WriteLine(test3.id);
			Console.WriteLine(test3.name);
        }
	}
}
