using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Hexagon : Shape
    {
        public List<Triangle> triangles;
        public static int ShapeScore = 1;
        
        public Hexagon(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 6);
        }
        public override bool Inside(ComparisionPoint p)
        {
            foreach(Triangle t in triangles)
            {
                if (t.Inside(p))
                {
                    return true;
                } 
            }
            return false;
        }
    }   
}