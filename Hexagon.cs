using System;

namespace ThiccShapes
{
    public class Hexagon : IShape
    {
        public static int ShapeScore = 1;
        
        public Hexagon(int x, int y, int Perimeter)
        {
            Console.WriteLine();
        }
        public bool Inside(int x, int y){return true;}
    }   
}