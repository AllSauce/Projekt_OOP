using System;

namespace ThiccShapes
{
    public class Point
    {
        public Point(int aX, int aY, int aPointScore)
        {
            X = aX;
            Y = aY;
            PointScore = aPointScore;
        }
        public int X {get; private set;}
        public int Y {get; private set;}
        public int PointScore {get; private set;}
    }
}