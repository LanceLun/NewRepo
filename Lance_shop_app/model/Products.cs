using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance_shop_app.model
{
	public class Products 
	{
		//創建商品
        public string Name { get; private set; }
        public int Price { get; private set; }
		public Products(string name, int price)
		{
			this.Name = name;
			this.Price = price;
		}
	}
}
