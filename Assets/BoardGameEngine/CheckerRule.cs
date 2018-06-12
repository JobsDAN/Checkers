using System;
using System.Collections.Generic;

namespace BoardGameEngine
{
    class CheckerRule : IRule
    {
        public ITurn checkTurn(Board board, Cell from, Cell to)
        {
            return new ManTurn(from, to);
        }

        public bool checkEnd(Board board)
        {
            // TODO: Add logic
            return true;
        }
    }
}