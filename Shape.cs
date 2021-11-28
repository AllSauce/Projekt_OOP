using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public abstract class Shape
    {   
        
        public List<Triangle> triangles;
        
        protected Point centerPoint;
        
        public virtual bool Inside(ComparisionPoint p, Algorithm a)
        {
            // returns true if point == centerpoint since triangles can't detect it
            if (p.X == centerPoint.X && p.Y == centerPoint.Y ) return true;

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