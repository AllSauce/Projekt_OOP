using System;

namespace ThiccShapes
{
    public class ComparisionPoint : Point
    {

        public ComparisionPoint(int aX, int aY, int aPointScore) :base(aX, aY)
        {
            PointScore = aPointScore;
            ray = new Line(this, new Point(Math.Pow(10, 100), aY));
        }
        Line ray;
        public int PointScore {get; private set;}
    }
}