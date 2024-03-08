using System;

namespace ThiccShapes
{
    //Comparrisionpoints used to compare in shapes. Is a point with pointscore and a ray
    public class ComparisionPoint : Point
    {
        public ComparisionPoint(int aX, int aY, int aPointScore) :base(aX, aY)
        {
            PointScore = aPointScore;
            //ray has one of the points being this point and the opther being one with the same Y but very large X. Should technically stretch to infinity
            ray = new Line(this, new Point(Math.Pow(10, 100), aY));
        }
        // Ray that alroritm.Intersectlines checks if it intersects with any of the triangles lines
        public Line ray;
        public int PointScore {get; private set;}
    }
}