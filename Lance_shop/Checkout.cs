using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance_shop
{
	public class Checkout
	{
		public string Name { get; private set; }
		private readonly List<Orders> _orders;
		public Checkout(string name, Orders[] orders)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new Exception("訂購人名子不得留空");
			}
			this.Name = name;
			this._orders = orders.ToList();
		}

		public void GetInFo(Func<int, int> func)
		{
			string result = string.Join("", _orders.Select(x => x.GetProductPrice()));
			int total = _orders.Sum(x => x.GetTotalPrice());
			Console.WriteLine($"{Name}你好\n{result}總金額為：{func(total)}");
		}
	}
}
