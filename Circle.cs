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
        public override bool Inside(ComparisionPoint p, Algorithm a)
        {
            double XLenght = Math.Abs(p.X - centerPoint.X);
            double YLenght = Math.Abs(p.Y - centerPoint.Y);
            double cLenght = Math.Sqrt((XLenght * XLenght) + (YLenght * YLenght));
            if (cLenght < Radius) return true;
            else return false;
            
        }
        public override int GetShapeScore(ShapeScore sc)
        {
            return sc.GetShapeScore(0);
        }
        public override double getArea()
        {
            return (Radius * Radius) * Math.PI;
        }
    }

}