using System.Collections;
using System.Collections.Generic;

namespace BoardGameEngine
{
    public interface IUnitFactory
    {
        Unit create(int x, int y, Unit.UnitType unitType);
    }
}