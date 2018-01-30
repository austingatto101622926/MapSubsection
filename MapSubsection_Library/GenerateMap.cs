using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSubsection_Library
{
    public class MapBuilder
    {
        int XMin;
        int XMax;
        int YMin;
        int YMax;

        int Width;
        int Height;

        int padding = 6;

        //New SubMap Values:
        int SideLength;
        Coords[] ShipCoord;
        Coords LowerLeftCoords;

        public SubMap GenerateSubMap(Map baseMap)
        {
            XMin = baseMap.ShipCoord.Select(C => C.X).Min();
            XMax = baseMap.ShipCoord.Select(C => C.X).Max();
            YMin = baseMap.ShipCoord.Select(C => C.Y).Min();
            YMax = baseMap.ShipCoord.Select(C => C.Y).Max();

            //Xmin Buffer
            if (XMin > padding)
            {
                XMin -= padding;
            }
            else
            {
                XMin = 0;
            }
            //XMax Buffer
            if (XMax < baseMap.SideLength - padding)
            {
                XMax += padding;
            }
            else
            {
                XMax = baseMap.SideLength;
            }
            //Ymin Buffer
            if (YMin > padding)
            {
                YMin -= padding;
            }
            else
            {
                YMin = 0;    
            }
            //Ymax Buffer
            if (YMax < baseMap.SideLength - padding)
            {
                YMax += padding;
            }
            else
            {
                YMax = baseMap.SideLength;
            }

            Height = YMax - YMin;
            Width = XMax - XMin;

            SideLength = Math.Max(Width, Height);

            ShipCoord = new Coords[baseMap.ShipCoord.Length];
            for (int i = 0; i < ShipCoord.Length; i++)
            {
                int newX = baseMap.ShipCoord[i].X - XMin;
                int newY = baseMap.ShipCoord[i].Y - YMin;

                ShipCoord[i] = new Coords(newX, newY);
            }

            LowerLeftCoords = new Coords(XMin, YMin);

            return new SubMap(baseMap, LowerLeftCoords, SideLength, ShipCoord);
        }
    }
}
