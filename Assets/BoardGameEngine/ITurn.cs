using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    interface ITurn
    {
        void perform(IBoard board);
    }
}
