using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class Invoice : 發票類別, 如果不會寫, 請捲到最下方去看答案
//屬性
//int Price : 未稅金額
//int Tax : 營業稅, ReadOnly
//int InclusivePrice : 含稅金額, ReadOnly
//Invoice(int price, double taxRate = 0.05
// class EStore : 在建構函數傳入營業稅率
//private int CalcTax(int price) :計算營業稅
//public Invoicet IssueInvoice(int price) : 開立發票, 傳回 Invoice 型別的物件
namespace Lance.OOP.Study
{
    public class Invoice
    {

		public int Price { get;private set; }
        public int Tax { get; private set; }
        public int InclusivePrice { get;private set; }

		public Invoice(int price,int tax,double taxRate = 0.05)
        {
		
            this.Price = price;
            this.Tax =tax;
            if (price >= 0) { InclusivePrice = Tax + Price; }
            else { InclusivePrice = Price - Tax; }
		}
        public bool IsBuy ()
        {
			return Price>=0;
        }
        private string Buy() 
        {
            return  $"未稅金額：{Price}\n營業稅：{Tax}\n含稅價：{InclusivePrice}";
		}
        private string Return()
        {
			return $"未稅金額：{InclusivePrice}\n營業稅：{Tax}\n含稅價：{Price}";
		}
		public static string IssueInvoiceResult(Invoice invoice)
		{
			return invoice.IsBuy() ? invoice.Buy() : invoice.Return();
		}



	}
}
