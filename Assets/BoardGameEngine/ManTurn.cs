using System;
using System.Text;

namespace BoardGameEngine
{
    public class ManTurn : ITurn
    {
        private Cell from;
        private Cell to;

        public ManTurn(Cell from, Cell to)
        {
            this.from = from;
            this.to = to;
        }

        public void Perform(Board board)
        {
        }
    }
}
