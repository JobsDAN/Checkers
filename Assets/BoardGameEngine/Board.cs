using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    public abstract class Board
    {
        public Cell[,] Cells { get; set; }

        public abstract void recreate();

    }

    public class CheckerBoard : Board
    {
        private IUnitFactory factory;
        const int SIDE_SIZE = 8;

        public CheckerBoard(IUnitFactory factory)
        {
            this.factory = factory;
            this.Cells = new Cell[SIDE_SIZE, SIDE_SIZE];
        }

        public override void recreate()
        {
            for (int i = 0; i < Cells.GetLength(0); i++) {
                for (int j = 0; j < Cells.GetLength(1); j++) {
                    Cell c = Cells[i, j];
                    c.horizontalPos = i;
                    c.verticalPos = j;
                    c.unit = null;
                }
            }
        }
    }
}
