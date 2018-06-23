using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;
using UnityEngine;

namespace BoardGameEngine
{
    public class Unit
    {
        public enum UnitType
        {
            BlackMen,
            WhiteMen,
            BlackKing,
            WhiteKing
        }

        public UnitType unitType;

        public Unit(UnitType unitType)
        {
            this.unitType = unitType;
        } 
    }
}