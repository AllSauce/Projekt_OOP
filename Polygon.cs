namespace ThiccShapes
{
    public class Polygon : Shape
    {
        
        int corners;
        public Polygon(Point p, int Perimeter, int aCorners, Algorithm a)
        {
            triangles = a.GetTriangles(a.GetPoints(p, Perimeter, aCorners), p);
            corners = aCorners;
        }
        public override int GetShapeScore()
        {
            return SC[corners - 2];
        }
    }
}