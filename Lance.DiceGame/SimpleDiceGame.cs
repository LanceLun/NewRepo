using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance.DiceGame
{
	public class SimpleDiceGame : BaseDiceGame
	{
		public SimpleDiceGame() : base("單顆骰子") { }

		public override string GetInformation()
		{ return(_dice.Count != 1) 
				? $"錯誤：{_dice.Count}" 
				: $"骰子點數為：{_dice[0].Value}"; 
		}
		

		public override void Play()
		{
			_dice.Add(Dice.Roll());
		}
	}
}
