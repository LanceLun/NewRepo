using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance_shop
{
	public class Orders
	{
		private int _quantity;
		private products _products;
		public Orders(int quantity, products orders)
		{
			if (quantity < 1) { throw new ArgumentOutOfRangeException("數量不得低於1"); }
			this._quantity = quantity;
			this._products = orders;
		}

		public string GetProductPrice()
		{
			return $"{_products.Name},購買數量為：{_quantity},金額為：{_products.Price * _quantity}\n";
		}
		public int GetTotalPrice()
		{
			return _products.Price * _quantity;
		}
	}
}
