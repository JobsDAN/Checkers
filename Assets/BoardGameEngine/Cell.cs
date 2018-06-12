using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    class Cell
    {
        public int horizontalPos { get; set; }
        public int verticalPos { get; set; }
        public Unit unit { get; set; }
    }
}
