using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 擴充方法
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}
	/// <summary>
	/// 擴充方法，class & method要加static，method第一個參數要加上this
	/// </summary>
	public static class StringHelper 
	{
		public static string Truncate(this string txt, int length)
		{
			if (string.IsNullOrEmpty(txt) || length <= 0)
			{
				return string.Empty;
			}
			if (txt.Length < length)
			{
				return txt;
			}
			return txt.Substring(0, length);
		}
	}
}
