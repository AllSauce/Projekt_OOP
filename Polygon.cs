namespace ThiccShapes
{
    public class Polygon : Shape
    {
        int corners;
        public Polygon(Point p, int Perimeter, int aCorners)
        {
            triangles = Algorithm.GetTriangles(p.X, p.Y, Perimeter, aCorners);
            corners = aCorners;
        }
        public override int GetShapeScore()
        {
            return SC[corners - 2];
        }
    }
}