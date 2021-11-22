using System;

namespace ThiccShapes
{
    public class Circle : IShape
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
        public bool Inside(int x, int y)
        {
            Console.WriteLine(Radius);
            int XLenght = Math.Abs(x - X);
            int YLenght = Math.Abs(y - Y);
            double cLenght = Math.Sqrt((XLenght * XLenght) + (YLenght * YLenght));
            if (cLenght < Radius) return true;
            else return false;
            
        }
    }

}