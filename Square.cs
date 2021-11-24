using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Sqaure : Shape
    {
        public static int ShapeScore = 1;
        
        
        public Sqaure(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 4);
        }
        
        public override int GetShapeScore()
        {
            return ShapeScore;
        }
    }
}