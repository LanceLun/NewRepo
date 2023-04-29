using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance_shop_app.model
{
	public class Order
	{
        /// <summary>
        /// 產品名稱
        /// </summary>
		public string ProductName { get;private set; }
        /// <summary>
        /// 單價
        /// </summary>
		public int Price { get;private set; }
        private int _qty;
        /// <summary>
        /// 數量
        /// </summary>
        public int Qty
        {
            get => _qty;
            set
            {
                _qty = value;
                TotalPrice = Price * _qty; 
            }
        }
        /// <summary>
        /// 總價格
        /// </summary>
        public int TotalPrice { get; private set; }
		public Order(string name,int price, int qty)
		{
			ProductName = name;
			Price = price;			
			Qty = qty;
		}
	}
}
