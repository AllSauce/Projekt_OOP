using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Pentagon : Shape
    {
        public static int ShapeScore = 1;
        public Pentagon(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 5);
        }        
        public override int GetShapeScore()
        {
            return ShapeScore;
        }
    }
}