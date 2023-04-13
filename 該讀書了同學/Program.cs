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
			Estore estore = new Estore(0.05);
			Invoice invoice = estore.IssueInvoice(10000);
			Console.WriteLine(invoice.Tax);
			Console.WriteLine(invoice.InclusivePrice);
		}
	}
}
