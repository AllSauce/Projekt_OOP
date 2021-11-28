using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Triangle : Shape
    {
        //Three points to represent the triangle
        Point P1;
        Point P2;
        Point P3;
        //Triangle represented in lines
        List<Line> lines = new List<Line>(); 
        //Constructor for creating triangle from input   
        public Triangle(Point p, int Perimeter, Algorithm a)
        {
            List<Point> points = a.GetPoints(p, Perimeter, 3);
            P1 = points[0];   
            P2 = points[1];  
            P3 = points[2];
            lines.Add(new Line(P1, P2));                                           
            lines.Add(new Line(P2, P3));                                           
            lines.Add(new Line(P3, P1));                                           
        }
        //Contancted to make triangles that contruct other shapes
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            lines.Add(new Line(p1, p2));
            lines.Add(new Line(p2, p3));
            lines.Add(new Line(p3, p1));
        }
        //Gets shapescore
        public override int GetShapeScore(ShapeScore sc)
        {
            return sc.GetShapeScore(1);
        }
        //Checks if a comppoint is inside of the triangle
        //Counts the number of times a ray casted from the Point touches the sides of the triangle
        //If it is inside the triangle it will touch once. Otherwise it will touch twice or not at all
        public override bool Inside(ComparisionPoint p, Algorithm a)
        {
            // Counts the amount of lines the ray touches
            int counter = 0;
            foreach(Line l in lines)
            {
                if (a.IntersectLine(l, p.ray))
                {
                    counter++;
                }
            }
            //Accounts for a special case where a point inside the triangle casts a ray that hits a vertice which would normally return false 

            if (p.Y == P1.Y && (p.Y > P2.Y && p.Y < P3.Y) || (p.Y < P2.Y && p.Y > P3.Y))
            {
                if (counter == 2) return true;
                else return false;
            }
            //Normal case
            else
            {
                if (counter == 1) return true;
                else return false;
            }

        }
        public override double getArea()
        {       
            //Trapezoids 
            return Math.Round(((0.5) * Math.Abs(P1.X*(P2.Y - P3.Y) + P2.X*(P3.Y - P1.Y) + P3.X*(P1.Y - P2.Y))), 5);
            
        }
    }
}