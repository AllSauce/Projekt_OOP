using System;

namespace ThiccShapes
{
    public class Pentagon : IShape
    {
        public static int ShapeScore = 1;
        public Pentagon(int x, int y, int Perimiter)
        {

        }
        public bool Inside(int x, int y){return true;}
    }
}