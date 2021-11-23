using System;

namespace ThiccShapes
{
    public class Pentagon : IShape
    {
        public static int ShapeScore = 1;
        public Pentagon(int x, int y, int Perimeter)
        {

        }
        public bool Inside(Point p){return true;}
    }
}