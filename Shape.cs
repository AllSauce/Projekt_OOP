using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public abstract class Shape
    {   
        
        public List<Triangle> triangles;
        protected static int[] SC = new int[6];
        public static void setSC(int sc, int index)
        {
            SC[index] = sc;
        }
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