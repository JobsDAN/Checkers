﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    public class Cell
    {
        public int horizontalPos { get; set; }
        public int verticalPos { get; set; }
        public Unit unit { get; set; }

        public Cell(int horizontalPos, int verticalPos, Unit unit)
        {
            this.horizontalPos = horizontalPos;
            this.verticalPos = verticalPos;
            this.unit = unit;
        }
    }
}
