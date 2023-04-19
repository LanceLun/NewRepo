using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance.DiceGame
{
	public interface IDiceGame
	{
		/// <summary>
		/// 玩一幾局
		/// </summary>
		void Play();

		/// <summary>
		/// 遊戲名稱
		/// </summary>
		/// <returns></returns>
		string Tital { get; }

		/// <summary>
		/// 遊戲點數和，視情況可覆蓋
		/// </summary>
		/// <returns></returns>
		int GetPoint();

		/// <summary>
		/// 獲取遊戲資訊
		/// </summary>
		/// <returns></returns>
		string GetInformation();

		/// <summary>
		/// 清空骰子
		/// </summary>
		void EmptyDice();
	}
}
