using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance_shop
{
	public class products : IComparable<products>
	{
		public string Name { get; private set; }
		public int Price { get; private set; }
		public products(string name, int price)
		{
			if (String.IsNullOrWhiteSpace(name)) { throw new Exception("產品名稱不得空白"); }
			if (price < 0) { throw new ArgumentOutOfRangeException("價格不得低於0"); }
			this.Name = name;
			this.Price = price;
		}

		public int CompareTo(products other)
		{
			return Price.CompareTo(other.Price);
		}

	}
}
