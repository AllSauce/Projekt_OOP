using System;

namespace ThiccShapes
{
    public class Circle : Shape
    {        
        public double Radius { get; private set;}

        public Circle(Point p, int Perimiter)
        {
            centerPoint = p;
            Radius = Perimiter / (2 * Math.PI);
        }
        //Checks if point is inside of circle
        public override bool Inside(ComparisionPoint p, Algorithm a)
        {
            //Pathyorgas theroem to calculate the lenght the point has from the center point
            double XLenght = Math.Abs(p.X - centerPoint.X);
            double YLenght = Math.Abs(p.Y - centerPoint.Y);
            double cLenght = Math.Sqrt((XLenght * XLenght) + (YLenght * YLenght));
            //if the point is further away than the radius it is outside
            if (cLenght < Radius) return true;
            else return false;
            
        }
        // Returns shapescore
        public override int GetShapeScore(ShapeScore sc)
        {
            return sc.GetShapeScore(0);
        }
        //Simple formula for Area
        public override double getArea()
        {
            return (Radius * Radius) * Math.PI;
        }
    }

}