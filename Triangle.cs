using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Triangle : Shape
    {
        
        Point P1;
        Point P2;
        Point P3;      
        List<Line> lines = new List<Line>();    
        public Triangle(int x, int y, int Perimeter, Algorithm a)
        {
            List<Point> points = new List<Point>();
            double radianperTurn = a.ToRadians(60);
            double sideLength = Perimeter / 3;        
            
            double hypotenus = (sideLength / 2) / Math.Cos(a.ToRadians(45))  ;
            double initalY = y - Math.Round(Math.Sqrt((hypotenus * hypotenus) - ((sideLength / 2) * (sideLength / 2))), 5);
            double initalX = x - sideLength / 2;
            P1 = new Point(initalX, initalY);
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
        public override int GetShapeScore()
        {
            return SC[1];
        }
        public override bool Inside(ComparisionPoint p, Algorithm a)
        {
            
            int counter = 0;
            foreach(Line l in lines)
            {
                if (a.IntersectLine(l, p.ray))
                {
                    counter++;
                }
            }
            if(p.Y != P1.Y && p.Y != P1.Y && p.Y != P1.Y)
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
        public override double getArea()
        {       
                
            return Math.Round(((0.5) * Math.Abs(P1.X*(P2.Y - P3.Y) + P2.X*(P3.Y - P1.Y) + P3.X*(P1.Y - P2.Y))), 5);
            
        }
    }
}