using System;

namespace ThiccShapes
{
    public class Heptagon : IShape
    {
        public static int ShapeScore = 1;
        public Heptagon(int x, int y, int Perimiter)
        {
            
        }
        public bool Inside(int x, int y){return true;}
    }   
}