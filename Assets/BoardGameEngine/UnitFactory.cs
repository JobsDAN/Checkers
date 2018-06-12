using System.Collections;
using System.Collections.Generic;

namespace BoardGameEngine
{
	public class UnitFactory : IUnitFactory
	{
		public Unit create(int x, int y, Unit.UnitType unitType)
		{
			return new Unit();
		}

	}
}