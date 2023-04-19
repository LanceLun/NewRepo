using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate委派_打折練習
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var order =new Order();
			int price = 1000;
			int result = 0;

			//打八折
			//myDiscount 八折 = p => p * 8 / 10;
			Func<int, int> 八折 = p => p * 8 / 10;
			result = order.CalcTotal(price,八折);


			//打五折
			//myDiscount 五折 = p => p / 2;
			Func<int, int> 五折 = p => p / 5;
			result = order.CalcTotal(price, 五折);

			//滿千送百
			//myDiscount 滿千送百 = p => (p > 1000) ? p - 100 : p;
			Func<int, int> 滿千送百 = p => (p > 1000) ? p - 100 : p;
			result = order.CalcTotal(price, 滿千送百);

			//打八折再滿千送百
			//myDiscount 打八折再滿千送百 = p => (p * 8 / 10 > 1000) ? p * 8 / 10 - 100 : p * 8 / 10;
			Func<int,int> 打八折再滿千送百=p=> (p * 8 / 10 > 1000) ? p * 8 / 10 - 100 : p * 8 / 10;
			result = order.CalcTotal(price, 打八折再滿千送百);

			//最常見的寫法，打八折
			int result2 = order.CalcTotal(price, p => p * 8 / 10);
		}
	}
	//public delegate int myDiscount(int price);
	public class Order
	{
		//可以支援不同委派的寫法比較好
		public int CalcTotal(int price,Func<int,int>func)
		{
			return func(price);
		}

	}
}
