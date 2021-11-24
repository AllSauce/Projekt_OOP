using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Octagon : Shape
    {
        
        public static int ShapeScore = 1;
        
        public Octagon(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 8);
        }
        
        public override int GetShapeScore()
        {
            return ShapeScore;
        }
    }   
}