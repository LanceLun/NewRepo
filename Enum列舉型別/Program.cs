using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum列舉型別
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//數字轉換成enum
			int test1 = 1;
			MaritalStatus maritalStatus = (MaritalStatus)test1;

			//判斷是否為enum
			bool isEnum = Enum.IsDefined(typeof(MaritalStatus), maritalStatus);

			//enum轉換成數字
			MaritalStatus test2 = MaritalStatus.Married;
			int result = (int)test2;

			//字串轉成enum
			string message = "Divorced";
			MaritalStatus result2 = (MaritalStatus)Enum.Parse(typeof(MaritalStatus),message);
		}
	}
	public enum OverrideFile 
	{
		若檔案存在就覆蓋,
		若檔案存在就丟出例外
	}
	public enum MaritalStatus 
	{	//宣告enum，不只定值，預設為
		Single,//單身0
		Married,//已婚1
		Divorced//離婚2
	}
	public enum Gender
	{	//宣告enum，指定值
		Male=1,
		Female=0
	}

}
