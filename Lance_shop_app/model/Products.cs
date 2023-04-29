using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance_shop_app.model
{
    // 這個應該要叫Product ?
    /// <summary>
    /// 產品 (案///可以打summary)
    /// </summary>
    public class Product 
	{
		/// <summary>
		/// 產品名稱
		/// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 產品實際值(進資料庫)
        /// </summary>
        public string Value { get; private set; }
        /// <summary>
        /// 價格
        /// </summary>
        public int Price { get; private set; }
		public Product(string name,string value, int price)
		{
			this.Name = name;
			this.Price = price;
            this.Value = value;
		}
	}
}
