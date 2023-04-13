using Lance.OOP.Study;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Estore estore = new Estore();
			Invoice invoice = estore.IssueInvoice(100);
			string test=Invoice.IssueInvoiceResult(invoice);
			Console.WriteLine(test);

		}
	}
}
