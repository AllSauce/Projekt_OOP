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

        public static double ToRadians(double deg) 
        {
            return deg * (Math.PI/180);
        }
        
        //Funkar typ
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

        
    }
}