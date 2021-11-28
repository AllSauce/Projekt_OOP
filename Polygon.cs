namespace ThiccShapes
{
    public class Polygon : Shape
    {
        //Amount of corners polygon has
        int corners;
        public Polygon(Point p, int Perimeter, int aCorners, Algorithm a)
        {
            //Gets triangles from injected algoritm
            triangles = a.GetTriangles(a.GetPoints(p, Perimeter, aCorners), p);
            corners = aCorners;
            centerPoint = p;
        }
        public override int GetShapeScore(ShapeScore sc)
        {
            return sc.GetShapeScore(corners - 2);
        }
    }
}