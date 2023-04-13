using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance.OOP.Study
{
	public class Estore
	{
		private double _taxRate;
		public Estore(double taxRate = 0.05)
		{
			if (taxRate < 0) { throw new Exception("稅率不得低於0%"); }
			if (taxRate >= 1) { throw new Exception("稅率不得高於100%"); }
			this._taxRate = taxRate;
		}
		private int calcTax(int price)
		{
			return (int)(price * _taxRate);
		}
		private int taxRefund(int price)
		{
			return (int)(price - price / (1 + _taxRate));
		}

		public Invoice IssueInvoice(int price)
		{
			if (price >= 0) 
			{
				int tax = calcTax(price);
				return new Invoice(price, tax);
			}
			else 
			{
				int tax = taxRefund(price);
				return new Invoice(price, tax);
			}
			
		}
	}
}
