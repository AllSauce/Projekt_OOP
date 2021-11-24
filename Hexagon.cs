using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Hexagon : Shape
    {
        
        public static int ShapeScore = 1;
        
        public Hexagon(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 6);
        }
        
        public override int GetShapeScore()
        {
            return ShapeScore;
        }
    }   
}