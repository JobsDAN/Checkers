using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    delegate void CellSelected(Cell cell);
    interface IPlayer
    {
        event CellSelected SelectEvent;
        event CellSelected DoEvent;
    }
}
