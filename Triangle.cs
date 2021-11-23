using System;

namespace ThiccShapes
{
    public class Triangle : IShape
    {
        
        public static int ShapeScore = 1;
        //Contancted to make standalone triangles from x, y and perimiter
        public Triangle(int x, int y, int Perimeter)
        {

        }
        //Contancted to make triangles that contruct other shapes
        //Send null or anything to overloader
        public Triangle(int x, int y, int z, int Overloader)
        {

            

        }


        
        public bool Inside(Point p)
        {
            return true;
        }
    }
}