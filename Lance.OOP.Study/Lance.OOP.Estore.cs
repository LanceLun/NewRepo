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
			this._taxRate = taxRate;
		}
		private int calcTax(int price)
		{
			return (int)(price * _taxRate);
		}
		public Invoice IssueInvoice(int price)
		{
			int tax = calcTax(price);
			return new Invoice(tax);
		}
	}
}
