using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public abstract class Shape
    {   
        //Every shape is represented in a list of triangles
        public List<Triangle> triangles;

        //Centerpoint of the shape
        protected Point centerPoint;

        //Checks if a point is inside, Defult impementation is asking every single triangle if the point is inside one of them
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
       
       // Returns area, Defult implementation is adding the area of every single triangle in the shape
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