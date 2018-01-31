using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSubsection_Library
{
    public class Map
    {
        public int SideLength;
        public Coords[] ShipCoord;
        
        public Map(int sideLength, Coords[] shipCoords)
        {
            SideLength = sideLength;
            ShipCoord = shipCoords;
        }
        public Map()
        {
            SideLength = 0;
        }
    }
}
