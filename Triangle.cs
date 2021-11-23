using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Triangle : IShape
    {
        Point P1;
        Point P2;
        Point P3;

        
        public static int ShapeScore = 1;
        List<Line> lines = new List<Line>();

        static void makeFunctions()
        {

        }
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
            lines.Add(new Line(p1, p2));
            lines.Add(new Line(p2, p3));
            lines.Add(new Line(p3, p1));

        }

        public bool Inside(ComparisionPoint p)
        {
            int counter = 0;
            foreach(Line l in lines)
            {
                if (Algorithm.IntersectLine(l, p.ray))
                {
                    counter++;
                }
            }
            if((p.Y != P1.Y) && (p.Y != P1.Y) && (p.Y != P1.Y))
            {
                if(counter == 1)
                {
                    return true;
                }
                else return false;
            }
            else 
            {
                if(counter == 2)
                {
                    return true;
                }
                else return false;
            }
            
        }
    }
}