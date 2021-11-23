using System;
using System.Collections;
using System.Collections.Generic;

namespace ThiccShapes
{
    static class Algorithm
    {

        //How the fuck do we find the vertices.
        public static ArrayList Vertices()
        {
            ArrayList coordinates = new ArrayList();
            return coordinates;
        }

        //Radius from centerpoint to a vertex of polygon
        public static double Radius(int sides, int midX, int midY, int perimeter)
        {
            double a = perimeter/sides;

            double r = (a/(2*Math.Sin(180/sides)));

            return r;
        }

        //Algorithm called Herons formula 
        //to find height of triangle (in case we need it lol)
        public static double HeightOfTriangle(int p)
        {
            double side = p/3;

            double s = p/2;

            //Area
            double A = Math.Sqrt(s*(s-side)*(s-side)*(s-side));

            //Height
            double h = (2*A)/side;

            return h;
        }

        //Could be put into circle class, this should work 
        //It checks if distance between point and mid is less than radius
        //If it is, then it is inside of circle
        public static bool IsInsideCircle(int midX, int midY, int pointX, int pointY, int perimeter)
        {
            bool deep = false;

            var R = perimeter/(2*Math.PI);
            var dLat = ToRadians(pointX-midX);
            var dLon = ToRadians(pointY-midY); 
            var a = 
                Math.Sin(dLat/2) * Math.Sin(dLat/2) +
                Math.Cos(ToRadians(midX)) * Math.Cos(ToRadians(pointX)) * 
                Math.Sin(dLon/2) * Math.Sin(dLon/2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a)); 
            var d = R * c;

            if(d < R)
            {
                deep = true;
            }

            return deep;
        }

        static double ToRadians(double deg) 
        {
            return deg * (Math.PI/180);
        }
        static double ToDeg(double radian)   
        {
            return (radian * Math.PI) / 180;
        }  
        //Funkar typ
        public static List<Triangle> GetTriangles(double x, double y, int Perimeter, int corners)
        {
            double sideLength = Perimeter / corners;
            List<Point> points = new List<Point>();
            int angleSumm = 180 * (corners - 2);   
            double anglePerTurn = angleSumm  / corners;         
            double radianperTurn = ToRadians(angleSumm / corners);
            double hypotenus = (sideLength / 2) / Math.Cos(ToRadians(45))  ;
            double initalY = y - Math.Sqrt((hypotenus * hypotenus) - ((sideLength / 2) * (sideLength / 2)));
            double initalX = x - sideLength / 2;
            Point initalPoint = new Point(initalX, initalY);
            points.Add(initalPoint);
            for(int i = 0; i < corners - 1; i++)
            {
                points.Add(RotatePoint(x, y, anglePerTurn, points[i]));
            }

            return null;
            
        }
        //Behlöver fixas
        private static Point RotatePoint(double cx, double cy, double angle, Point p)
        {
            //Sinus och Cosinus av vinkeln
            double s = Math.Sin(ToRadians(angle));
            double c = Math.Cos(ToRadians(angle));

            //Temporära variabler som kan förändras
            double temppX = p.X;
            double temppY = p.Y;

            temppX -= cx;
            temppY -= cy;

            //Nya roterade värden på x och y
            double xNew = temppX * c - temppY * s;
            double yNew = temppX * s + temppY * c;

            return new Point(xNew, yNew);
        }

        
    }
}