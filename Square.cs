using System;

namespace ThiccShapes
{
    public class Sqaure : IShape
    {
        public static int ShapeScore = 1;
        public Sqaure(int x, int y, int Perimiter)
        {

        }
        public bool Inside(int x, int y){return true;}
    }
}