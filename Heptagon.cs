using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Heptagon : Shape
    {
        
        public static int ShapeScore = 1;
        public Heptagon(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 7);
        }
        
        public override int GetShapeScore()
        {
            return ShapeScore;
        }
    }   
}