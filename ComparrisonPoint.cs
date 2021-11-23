namespace ThiccShapes
{
    public class ComparisionPoint : Point
    {

        public ComparisionPoint(int aX, int aY, int aPointScore) :base(aX, aY)
        {
            PointScore = aPointScore;
        }
        public int PointScore {get; private set;}
    }
}