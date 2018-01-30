using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapSubsection_Library;

namespace MapSubsection
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords[] ShipCoords = new Coords[]
            {
                new Coords(100, 150),
                new Coords(120, 150),
                new Coords(140, 160),
                new Coords(160, 180)
            };

            Map map = new Map(200, ShipCoords);

            MapBuilder bob = new MapBuilder();

            SubMap subMap = bob.GenerateSubMap(map);


            //DISPLAY
            Console.Write(subMap.SideLength);
            Console.WriteLine(subMap.LowerLeftCoords);

            //DRAW BORDER
            for (int i = 0; i < subMap.SideLength; i++) Console.Write('#'); //top
            Console.CursorTop = subMap.SideLength-1;
            Console.CursorLeft = 0;
            for (int i = 0; i < subMap.SideLength; i++) Console.Write('#'); //Bootom

            for (int i = 1; i < subMap.SideLength-1; i++) //Left
            {
                Console.CursorLeft = 0;
                Console.CursorTop = i;
                Console.Write('#');
            }

            for (int i = 1; i < subMap.SideLength - 1; i++) //Right
            {
                Console.CursorLeft = subMap.SideLength-1;
                Console.CursorTop = i;
                Console.Write('#');
            }

            foreach (Coords shipCoord in subMap.ShipCoord)
            {
                Console.CursorTop = subMap.SideLength - shipCoord.Y;
                Console.CursorLeft = shipCoord.X;
                Console.Write('A');
            }
           
            Console.ReadLine();
        }
    }
}
