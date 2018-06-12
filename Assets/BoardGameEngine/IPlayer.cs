using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGameEngine
{
    interface IPlayer
    {
        event EventHandler cellSelected;
    }
}
