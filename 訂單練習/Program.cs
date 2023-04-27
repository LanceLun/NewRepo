using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 訂單練習
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var product1 = new Products("Toyota", 30000);
			var product2 = new Products("Audi", 50000);
			var product3 = new Products("Maserati", 80000);

			var apple = new Checkout("Allpe", new Orders[]
			{
				new Orders(1,product1 ),
				new Orders(2,product2 ),
				new Orders(3,product3 )
			});

			Func<int, int> 折扣 = 
				x => (int)Math.Round((double)x * 9 / 10, MidpointRounding.AwayFromZero);  
			apple.GetInFo(折扣);

		}
	}


	/// <summary>
	/// 新增產品，必須要有品名及價格
	/// </summary>
	public class Products:IComparable<Products>
	{
        public string Name { get;private set; }
        public int Price { get;private set; }
        public Products(string name,int price)
        {
			if (String.IsNullOrWhiteSpace(name)) { throw new Exception("產品名稱不得空白"); }
			if (price < 0) { throw new ArgumentOutOfRangeException("價格不得低於0"); }
			this.Name = name;
			this.Price = price;
        }

		public int CompareTo(Products other)
		{
			return Price.CompareTo(other.Price);
		}

	}



	/// <summary>
	/// 下單
	/// </summary>
	public class Orders
	{
		private int _quantity;
		private Products _products;
        public Orders(int quantity, Products orders)
        {
			if (quantity < 1) { throw new ArgumentOutOfRangeException("數量不得低於1"); }
			this._quantity = quantity;
			this._products = orders;
		}

		public string GetProductPrice()
		{
			return $"{_products.Name},購買數量為：{_quantity},金額為：{_products.Price* _quantity}\n";
		}
		public int GetTotalPrice()
		{
			return _products.Price * _quantity;
		}
    }


	public class Checkout
	{
        public string Name { get;private set; }
		private readonly List<Orders> _orders;
        public Checkout(string name, Orders[] orders)
        {
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new Exception("訂購人名子不得留空");
			}
			this.Name=name;
			this._orders= orders.ToList();
		}

		public void GetInFo(Func<int,int> func)
		{
			string result = string.Join("", _orders.Select(x => x.GetProductPrice()));
			int total = _orders.Sum(x => x.GetTotalPrice());
            Console.WriteLine($"{Name}你好\n{result}總金額為：{func(total)}");
		}

    }

}
