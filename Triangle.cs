using System;

namespace ThiccShapes
{
    public class Triangle : IShape
    {
        Point P1;
        Point P2;
        Point P3;
    
        public static int ShapeScore = 1;
        //Contancted to make standalone triangles from x, y and perimiter
        public Triangle(int x, int y, int Perimeter)
        {
            
        }
        //Contancted to make triangles that contruct other shapes
        //Send null or anything to overloader
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;            
        }        
        public bool Inside(Point p)
        {
            return true;
        }
    }
}