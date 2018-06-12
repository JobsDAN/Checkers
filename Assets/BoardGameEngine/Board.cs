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
        public const int BoardSize = 8;

        public CheckerBoard(IUnitFactory factory)
        {
            this.factory = factory;
            this.Cells = new Cell[BoardSize, BoardSize];
            recreate();
        }

        public override void recreate()
        {
            for (int i = 0; i < BoardSize; i++) {
                for (int j = 0; j < BoardSize; j++) {
                    Unit unit = factory.create(i, j, Unit.UnitType.Men);
                    Cells[i, j] = new Cell(i, j, unit);
                }
            }
        }
    }
}
