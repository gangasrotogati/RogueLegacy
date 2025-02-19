﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelight.Core
{
    // Direction values correspond to numpad numbers
    public enum Direction
    {
        None = 0,
        DownLeft = 1,
        Down = 2,
        DownRight = 3,
        Left = 4,
        Center = 5,
        Right = 6,
        UpLeft = 7,
        Up = 8,
        UpRight = 9,
        DownStairs = 10,
        UpStairs = 11
    }
}
