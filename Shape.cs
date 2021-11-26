using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public abstract class Shape
    {   
        
        public List<Triangle> triangles;
        
        
        public virtual bool Inside(ComparisionPoint p, Algorithm a)
        {
            foreach(Triangle t in triangles)
            {
                if (t.Inside(p, a))
                {
                    return true;
                } 
            }
            return false;
        }
        public abstract int GetShapeScore(ShapeScore sc);
       
        public virtual double getArea()
        {
            double d = 0;
            foreach (Triangle t in triangles)
            {
                d = d + t.getArea();
            }
            return d;
        }
    }
}