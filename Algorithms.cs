using System;
using System.Collections;

namespace ThiccShapes
{
    class Algorithm
    {

        //How the fuck do we find the vertices. And how will we take care of the circle ;(
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

    }
}