using System;
using System.Collections;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Algorithm
    {    

        public List<Point> GetPoints(Point centerpoint, double Perimeter, double corners)
        {
            double sideLength = Perimeter / corners;
            List<Point> points = new List<Point>();
            double angleSumm = 180 * (corners - 2);
            double radianperTurn = ToRadians(angleSumm / corners);
            if(corners % 2 != 0)
            {
                radianperTurn = radianperTurn * 2;
            }        
            
            double hypotenus = (sideLength / 2) / Math.Cos(ToRadians(angleSumm / (corners * 2)));
            double initalY = centerpoint.Y - Math.Round(Math.Sqrt((hypotenus * hypotenus) - ((sideLength / 2) * (sideLength / 2))), 5);
            double initalX = centerpoint.X - sideLength / 2;
            Point initalPoint = new Point(initalX, initalY);
            points.Add(initalPoint);
            
            for(int i = 0; i < corners - 1; i++)
            {
                points.Add(RotatePoint(new Line(centerpoint, points[i]), radianperTurn));
            }
            return points;

        } 
        //Funkar 
        public List<Triangle> GetTriangles(List<Point> points, Point centerPoint)
        {
            
            List<Triangle> triangles = new List<Triangle>();
            for(int i = 1; i < points.Count; i++)
            {
                triangles.Add(new Triangle(points[i], points[i - 1], centerPoint));
            }
            triangles.Add(new Triangle(points[0], points[points.Count - 1], centerPoint));
            return triangles;
            
        }
        public double ToRadians(double deg) 
        {
            return deg * (Math.PI/180);
        }
        
        //Så jävla vacker :))))))))
        public Point RotatePoint(Line l, double radian)
        {
            //Sinus och Cosinus av vinkeln
            double s = Math.Sin(radian);
            double c = Math.Cos(radian);

            //Temporära variabler som kan förändras
            double temppX = l.P2.X - l.P1.X;
            double temppY = l.P2.Y - l.P1.Y;

            //Nya roterade värden på x och y
            double xNew = temppX * c - temppY * s;
            double yNew = temppX * s + temppY * c;

            xNew += l.P1.X;
            yNew += l.P1.Y;

            return new Point(Math.Round(xNew, 5), Math.Round(yNew, 5));
        }

        public bool IntersectLine(Line l1, Line l2)
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