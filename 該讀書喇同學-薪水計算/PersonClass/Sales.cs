﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 該讀書喇同學_薪水計算
{
	internal class Sales:Employee
	{
		/// <summary>
		/// 業務-領底薪加業績%10，如果業績超過10W額外給bonus
		/// </summary>
		private int Achievement;
		public Sales(string name, bool gender, string id, string position, int baseSalary, int achievement) : base(name, gender, id, position, baseSalary)
		{
			if (achievement < 0)
			{
				throw new Exception("業績沒有負數");
			}
			this.Achievement = achievement;
		}
		public override int GetSalary()
		{
			int bonus = 0;
			if (Achievement >= 100000)
			{
				bonus = (int)Math.Round(((double)Achievement / 10), MidpointRounding.AwayFromZero) + 10000;
				return base.GetSalary() + bonus;
			}
			else
			{
				bonus = (int)Math.Round(((double)Achievement / 10), MidpointRounding.AwayFromZero);
				return base.GetSalary() + bonus;
			}

		}
		
	}
}
