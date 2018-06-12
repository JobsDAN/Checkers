using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    public delegate void CellSelected(Cell cell);
    interface IPlayer
    {
        event CellSelected CellSelected;
        event CellSelected DoEvent;
    }
}
