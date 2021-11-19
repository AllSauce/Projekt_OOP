using System;

namespace ThiccShapes
{
    public class Triangle : IShape
    {
        public static int ShapeScore = 1;
        public Triangle(int x, int y, int Perimiter)
        {

        }
        public bool Inside(int x, int y){return true;}
    }
}