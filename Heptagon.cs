using System;

namespace ThiccShapes
{
    public class Heptagon : IShape
    {
        public static int ShapeScore = 1;
        public Heptagon(int x, int y, int Perimeter)
        {
            
        }
        public bool Inside(Point p){return true;}
    }   
}