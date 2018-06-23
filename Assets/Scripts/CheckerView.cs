using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoardGameEngine;
using UnityEngine;


public class CheckerView : MonoBehaviour {
    private Unit unit;

    public void setUnit(Unit unit) {
        this.unit = unit;
    }
}