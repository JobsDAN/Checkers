using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    interface IRule
    {
        ITurn validate(Board board);
    }
}
