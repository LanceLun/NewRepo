using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lance.DiceGame
{
    public class Dice:IComparable<Dice>
    {
        public int Value { get;private set; }
		public override string ToString()
		{
			return this.Value.ToString();
		}

		public static Dice Roll(IRandom random=null)
		{
			random = random ?? new DefaultRandom();
			return new Dice() { Value=random.Next(1,7)};
		}

		public int CompareTo(Dice other)
		{
			return this.Value.CompareTo(other.Value);
		}

		public interface IRandom
        {
            int Next(int min, int max);
        }
		public class DefaultRandom : IRandom
		{
			public int Next(int min, int max)
			{
				int seed=Guid.NewGuid().GetHashCode();
				return new Random(seed).Next(min,max);
			}
		}

	}
}
