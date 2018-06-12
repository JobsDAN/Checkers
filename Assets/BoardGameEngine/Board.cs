using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    abstract class Board
    {
        public List<Cell> Cells { get; set; }

        public abstract void recreate();
    }
}
