﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    interface IRule
    {
        ITurn checkTurn(Board board, Cell from, Cell to);
        bool checkEnd(Board board);
    }
}
