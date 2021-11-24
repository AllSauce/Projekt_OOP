using System;

namespace ThiccShapes
{
    public class Circle : Shape
    {
        public static int ShapeScore = 1;
        public int X { get; private set;}
        public int Y { get; private set;}
        public double Radius { get; private set;}

        public Circle(int aX, int aY, int Perimiter)
        {
            X = aX;
            Y = aY;
            Radius = Perimiter / (2 * Math.PI);
        }
        public override bool Inside(ComparisionPoint p)
        {
            double XLenght = Math.Abs(p.X - X);
            double YLenght = Math.Abs(p.Y - Y);
            double cLenght = Math.Sqrt((XLenght * XLenght) + (YLenght * YLenght));
            if (cLenght < Radius) return true;
            else return false;
            
        }
        public override int GetShapeScore()
        {
            return ShapeScore;
        }
        public override double getArea()
        {
            return (Radius * 2) * Math.PI;
        }
    }

}