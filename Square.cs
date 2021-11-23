using System;

namespace ThiccShapes
{
    public class Sqaure : IShape
    {
        public static int ShapeScore = 1;
        public Sqaure(int x, int y, int Perimeter)
        {

        }
        public bool Inside(Point p){return true;}
    }
}