using System;
using System.Collections;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Algorithm
    {    
        //Gets points of verticies from a centerpoint, perimiter and the amount of corners
        public List<Point> GetPoints(Point centerpoint, double Perimeter, double corners)
        {
            //Preparations
            double sideLength = Perimeter / corners;           
            double angleSumm = 180 * (corners - 2);
            double radianperTurn = ToRadians(angleSumm / corners);
            if(corners % 2 != 0)
            {
                radianperTurn = ToRadians(angleSumm / corners*2);
            }        
            
            //Calculates the initalpoint, from where rotations will be made
            double hypotenus = (sideLength / 2) / Math.Cos(ToRadians(angleSumm / (corners * 2)));
            double initalY = centerpoint.Y - Math.Round(Math.Sqrt((hypotenus * hypotenus) - ((sideLength / 2) * (sideLength / 2))), 5);
            double initalX = centerpoint.X - sideLength / 2;

            //Return List
            List<Point> points = new List<Point>();

            //Adds initalPoint to the list
            Point initalPoint = new Point(initalX, initalY);
            points.Add(initalPoint);
            
            for(int i = 0; i < corners - 1; i++)
            {
                points.Add(RotatePoint(new Line(centerpoint, points[i]), radianperTurn));
            }
            return points;

        } 

        //Helpermethod
        public double ToRadians(double deg) 
        {
            return deg * (Math.PI/180);
        }

        //Gets triangles from a list of points
        public List<Triangle> GetTriangles(List<Point> points, Point centerPoint)
        {
            //Return List
            List<Triangle> triangles = new List<Triangle>();

            //Loops and used last two poitns + centerpoint to create a triangle
            for(int i = 1; i < points.Count; i++)
            {
                triangles.Add(new Triangle(points[i], points[i - 1], centerPoint));
            }

            //To avoid going out of index the intial one has to be outside
            triangles.Add(new Triangle(points[0], points[points.Count - 1], centerPoint));

            return triangles;
            
        }
               
        //HelperMethod
        //Roatates around the centerpoint based on the lenght of the line and how far you would like to rotate
        public Point RotatePoint(Line l, double radian)
        {
            //Sinus och Cosinus of the angle
            double s = Math.Sin(radian);
            double c = Math.Cos(radian);

            //Temporary variables that can change
            double temppX = l.P2.X - l.P1.X;
            double temppY = l.P2.Y - l.P1.Y;

            //Newrotated values of X and Y
            double xNew = temppX * c - temppY * s;
            double yNew = temppX * s + temppY * c;

            xNew += l.P1.X;
            yNew += l.P1.Y;

            return new Point(Math.Round(xNew, 5), Math.Round(yNew, 5));
        }

        //Checks if two lines intersect
        //Used to calculate if a point is inside of a triangle
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

            if(D == 0) return false;

            //X and Y values of intersection point
            double t = ((x1 - x3)*(y3 - y4) - (y1 - y3)*(x3 - x4))/D;
            double u = ((x1 - x3)*(y1 - y2) - (y1 - y3)*(x1 - x2))/D;

            if(t >= 0 && t <= 1 && u >= 0 && u <= 1)
            {
                return true;
            }

            return false;
        }
    }
}