using System;

namespace ThiccShapes
{
    public class Circle : IShape
    {
        public static int ShapeScore = 1;
        public Circle(int x, int y, int Perimeter)
        {
                

        }
        public bool Inside(int x, int y){return true;}
    }

}