using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    public delegate void CellCelected(Cell cell);
    interface IPlayer
    {
        event CellCelected cellSelected;
    }
}
