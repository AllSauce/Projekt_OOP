using System;
using System.Collections;
using System.Collections.Generic;

namespace ThiccShapes
{
    static class Algorithm
    {
        public static double PointsGet(Tuple<List<ComparisionPoint> , List<Shape>> t1)
        {
            double counter = 0;
            foreach(Shape s in t1.Item2)
            {
                foreach(ComparisionPoint p in t1.Item1)
                {
                    if (s.Inside(p))
                    {
                        counter = counter + (s.getArea() * s.GetShapeScore() * p.PointScore);
                    }
                    else counter = counter + ((s.getArea() * s.GetShapeScore()) / 4);
                }
            }
            return counter;
        }
        public static double ToRadians(double deg) 
        {
            return deg * (Math.PI/180);
        }
        
        //Funkar 
        public static List<Triangle> GetTriangles(double x, double y, int Perimeter, int corners)
        {
            double sideLength = Perimeter / corners;
            List<Point> points = new List<Point>();
            int angleSumm = 180 * (corners - 2);   
                    
            double radianperTurn = ToRadians(angleSumm / corners);
            double hypotenus = (sideLength / 2) / Math.Cos(ToRadians(45))  ;
            double initalY = y - Math.Round(Math.Sqrt((hypotenus * hypotenus) - ((sideLength / 2) * (sideLength / 2))), 5);
            double initalX = x - sideLength / 2;
            Point initalPoint = new Point(initalX, initalY);
            points.Add(initalPoint);
            Point centerPoint = new Point(x, y);
            for(int i = 0; i < corners - 1; i++)
            {
                points.Add(RotatePoint(x, y, radianperTurn, points[i]));
            }
            List<Triangle> triangles = new List<Triangle>();
            for(int i = 1; i < points.Count; i++)
            {
                triangles.Add(new Triangle(points[i], points[i - 1], centerPoint));
            }
            triangles.Add(new Triangle(points[0], points[points.Count - 1], centerPoint));
            return triangles;
            
        }
        
        //Så jävla vacker :))))))))
        private static Point RotatePoint(double cx, double cy, double radian, Point p)
        {
            //Sinus och Cosinus av vinkeln
            double s = Math.Sin(radian);
            double c = Math.Cos(radian);

            //Temporära variabler som kan förändras
            double temppX = p.X - cx;
            double temppY = p.Y - cy;

            //Nya roterade värden på x och y
            double xNew = temppX * c - temppY * s;
            double yNew = temppX * s + temppY * c;

            xNew += cx;
            yNew += cy;

            return new Point(Math.Round(xNew, 5), Math.Round(yNew, 5));
        }

        public static bool IntersectLine(Line l1, Line l2)
        {
            //Instantiating X values
            double x1 = l1.P1.X;
            double x2 = l1.P2.X;
            double x3 = l2.P1.X;
            double x4 = l2.P2.X;

            //Instantiating Y values
            double y1 = l1.P1.Y;
            double y2 = l1.P2.Y;
            double y3 = l2.P1.Y;
            double y4 = l2.P2.Y;

            //Denominator
            double D = (x1 - x2)*(y3 - y4) - (y1 - y2)*(x3 - x4);

            if(D == 0)
            {return false;}

            //X and Y values of intersection point
            double t = ((x1 - x3)*(y3 - y4) - (y1 - y3)*(x3 - x4))/D;
            double u = ((x1 - x3)*(y1 - y2) - (y1 - y3)*(x3 - x4))/D;

            if(t >= 0 && t <= 1 && u >= 0 && u <= 1)
            {
                return true;
            }

            return false;
        }
    }
}