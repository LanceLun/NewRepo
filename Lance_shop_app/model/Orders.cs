using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance_shop_app.model
{
	public class Orders
	{
		//product加入數量變order
		public Products Products { get;private set; }
		public int Qty { get;private set; }
		public int TotalPrice { get;private set; }
		public Orders(Products products, int qty)
		{
			this.Products = products;
			Qty = qty;
			TotalPrice = qty * products.Price;
		}
	}

	public static class OrdersHelper
	{
		static public List<(string name,int price, int qty)> GetOrderSum(this List<Orders> orders)
		{
			var summary = orders.Where(o => o.Qty > 0)
				.GroupBy(o => o.Products.Name)
				.Select(g => (g.Key, g.Sum(o => o.Qty), g.Sum(o => o.TotalPrice)))
				.ToList();
			return summary;
		}

		static public int GetOrderTotalPrice(this List<Orders> orders)
		{
			return orders.Sum(o => o.TotalPrice);
		}

	}

}
