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
		static public int GetOrderTotalPrice(this List<Orders> orders)
		{
			return orders.Sum(o => o.TotalPrice);
		}

	}

}
