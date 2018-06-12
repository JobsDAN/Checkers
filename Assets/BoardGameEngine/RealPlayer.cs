using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BoardGameEngine
{
    class RealPlayer : MonoBehaviour, IPlayer
    {
        public event EventHandler cellSelected;

    }
}
