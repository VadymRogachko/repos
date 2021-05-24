using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
	class Accauntant
	{
		public bool AskForBonus(Positions worker, int hours)
		{
			if (hours > (int) worker)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
