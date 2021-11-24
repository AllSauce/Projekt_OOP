using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Octagon : Shape
    {
        public List<Triangle> triangles;
        public static int ShapeScore = 1;
        
        public Octagon(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 8);
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
        public override int GetShapeScore()
        {
            return ShapeScore;
        }
    }   
}