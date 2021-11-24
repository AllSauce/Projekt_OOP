using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public abstract class Shape
    {   
        public List<Triangle> triangles;
        public virtual bool Inside(ComparisionPoint p)
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
        public abstract int GetShapeScore();
        public abstract double getArea();
    }
}