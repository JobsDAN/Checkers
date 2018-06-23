using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{ 
    public delegate void BoardRecreated(Cell[,] cells);
    public interface IBoard
    {
        Cell[,] Cells { get; set; }

        event BoardRecreated boardRecreated;
        void recreate();
    }

    public class CheckerBoard : IBoard
    {
        private IUnitFactory factory;
        public const int BoardSize = 8;

        public event BoardRecreated boardRecreated;

        public Cell[,] Cells { get; set; }

        public CheckerBoard(IUnitFactory factory) {
            this.factory = factory;
        }

        public void recreate()
        {
            Cells = new Cell[BoardSize, BoardSize];
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    if ((j + i) % 2 != 0)
                    {
                        Cells[i, j] = new Cell(j, i, null);
                    }
                    else
                    {
                        if (i < 3)
                        {
                            Cells[i, j] = new Cell(j, i, factory.create(j, i, Unit.UnitType.WhiteMen));
                        }
                        else if (i > 4)
                        {
                            Cells[i, j] = new Cell(j, i, factory.create(j, i, Unit.UnitType.BlackMen));
                        }
                        else
                        {
                            Cells[i, j] = new Cell(j, i, null);
                        }
                    }
                }
            }

            if (boardRecreated != null)
                boardRecreated(Cells);
        }
    }
}
