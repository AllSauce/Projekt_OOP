using System;
using System.Collections;

namespace ThiccShapes
{
    class Algorithm
    {

        //How the fuck do we find the vertices.
        public ArrayList Vertices()
        {
            ArrayList coordinates = new ArrayList();
            return coordinates;
        }

        //Radius from centerpoint to a vertex of polygon
        public double Radius(int sides, int midX, int midY, int perimeter)
        {
            double a = perimeter/sides;

            double r = (a/(2*Math.Sin(180/sides)));

            return r;
        }

        //Algorithm called Herons formula 
        //to find height of triangle (in case we need it lol)
        public double HeightOfTriangle(int p)
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
        public bool IsInsideCircle(int midX, int midY, int pointX, int pointY, int perimeter)
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

        double ToRadians(double deg) 
        {
            return deg * (Math.PI/180);
        }

    }
}