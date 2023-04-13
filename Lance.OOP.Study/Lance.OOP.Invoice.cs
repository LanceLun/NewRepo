using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance.OOP.Study
{
    public class Invoice
    {
        public int Price { get;private set; }
        public int Tax { get; private set; }
        public int InclusivePrice { get; private set; }

		//class Invoice : 發票類別, 如果不會寫, 請捲到最下方去看答案
		//屬性
		//int Price : 未稅金額
		//int Tax : 營業稅, ReadOnly
		//int InclusivePrice : 含稅金額, ReadOnly
		//Invoice(int price, double taxRate = 0.05
		// class EStore : 在建構函數傳入營業稅率
		//private int CalcTax(int price) :計算營業稅
		//public Invoicet IssueInvoice(int price) : 開立發票, 傳回 Invoice 型別的物件
		public Invoice(int price,double taxRate = 0.05)
        {
            this.Price = price;
            Tax =(int)(price*taxRate);
			InclusivePrice = Tax + Price;
        }

    }
}
