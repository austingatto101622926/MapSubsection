using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSubsection_Library
{
    public class SubMap : Map
    {
        public Map BaseMap;
        public Coords LowerLeftCoords;

        public SubMap(Map baseMap, Coords lowerLeftCoords, int sideLength, Coords[] shipCoord) : base(sideLength, shipCoord)
        {
            BaseMap = baseMap;
            LowerLeftCoords = lowerLeftCoords;
        }
    }
}
