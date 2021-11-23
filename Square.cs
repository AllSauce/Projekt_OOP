using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Sqaure : IShape
    {
        public static int ShapeScore = 1;
        public List<Triangle> triangles;
        
        public Sqaure(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 4);
        }
        public bool Inside(Point p)
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