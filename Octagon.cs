using System;

namespace ThiccShapes
{
    public class Octagon : IShape
    {
        public static int ShapeScore = 1;
        public Octagon(int x, int y, int Perimiter)
        {
            
        }
        public bool Inside(int x, int y){return true;}
    }   
}