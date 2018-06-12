using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    public abstract class Board
    {
        public List<Cell> Cells { get; set; }

        public abstract void recreate();

    }

    public class CheckerBoard : Board
    {
        private IUnitFactory factory;

        public CheckerBoard(IUnitFactory factory) {
            this.factory = factory;
        }

        public override void recreate()
        {
        }
    }
}
