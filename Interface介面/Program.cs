using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface介面
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IFriend friend = new Siri();
			friend.SayHi("Lance");
		}
	}
	interface IMember //命名用大寫I開頭
	{   //不能寫File、建構函數
		//只能宣告Property
		int Id { get; set; }//只能宣告，不能在get，set裡寫程式

		void Save(string mseeage);//method不能寫public，private
	}

	interface IFriend
	{
		void SayHi(string name);
	}

	class Siri : IFriend
	{
		public void SayHi(string name)//必須是public，簽名碼要相同
		{
			Console.WriteLine($"Hi,{name}");
		}
	}

	class Person { }
	class Empolyee : Person, IMember, IFriend
	{
		public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Save(string mseeage)
		{
			throw new NotImplementedException();
		}

		public void SayHi(string name)
		{
			Console.WriteLine($"Hi,{name}");
		}
	}
}
