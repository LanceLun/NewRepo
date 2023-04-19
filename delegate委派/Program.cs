using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate委派
{
	delegate void XXX(int num);
	public delegate int Operation(int num1, int num2);
	public delegate bool Operation2(int num3);
	internal class Program
	{	//委派與method簽名碼要相同
		static void Main(string[] args)
		{
			//兩個都可以創建委派
			XXX test=new XXX(YYY);
			XXX test1 = YYY;
		}
		static void YYY(int num)
		{
			Console.WriteLine(num);
		}

		static void Demo01()
		{
			//由於委派簽名碼相同，兩個type肯定都是int，所以可以省略，電腦會分辨
			//如果參數只有一個，可以省略type跟()
			Operation QQ = (num1, num2) =>{ return num1 + num2; };
			Operation2 WW = num3 => { return num3 > 0; };
		}
		static void Demo02()
		{
			//最常見的寫法，一行程式碼能表示才可以用
			Operation QQ = (num1, num2) => num1 + num2;
			Operation2 WW = num3 => num3 > 0;
		}
	}
	
}
