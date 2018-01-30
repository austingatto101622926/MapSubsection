﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSubsection_Library
{
    public class Coords
    {
        public int X;
        public int Y;
        
        public Coords(int x, int y)
        {
            X = x;
            Y = y;

        }

        public override string ToString()
        {
            return "("+X+","+Y+")";
        }
    }
}
