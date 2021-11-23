using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Pentagon : IShape
    {
        public List<Triangle> triangles;
        public static int ShapeScore = 1;
        public Pentagon(int x, int y, int Perimeter)
        {
            triangles = Algorithm.GetTriangles(x, y, Perimeter, 5);
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