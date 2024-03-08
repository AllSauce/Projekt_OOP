using System;

namespace ThiccShapes
{
    //Datatype to more easily represent points
    public class Point
    {
        public Point(double aX, double aY)
        {
            X = aX;
            Y = aY;
        }
        
        public double X {get; private set;}
        public double Y {get; private set;}
        
    }
}