using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance.DiceGame
{
	public abstract class BaseDiceGame : IDiceGame
	{
		protected List<Dice> _dice=new List<Dice> ();
		public string Tital { get; }
        public BaseDiceGame(string tital)
        {
			this.Tital = tital;
        }


        public void EmptyDice()
		{
			_dice.Clear();
		}

		public abstract string GetInformation();

		public virtual int GetPoint()=> _dice.Sum(point => point.Value);


		public abstract void Play();
		
	}
}
