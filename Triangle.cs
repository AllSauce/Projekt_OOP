using System;

namespace ThiccShapes
{
    public class Triangle : IShape
    {
        
        public static int ShapeScore = 1;
        public Triangle(int x, int y, int Perimeter)
        {

        }
        public Triangle(int x, int y, int z, int Overloader)
        {

            

        }


        
        public bool Inside(int x, int y){return true;}
    }
}