using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Program
    {
        static void Main(string[] args)
        {
                        
            Algorithm.GetTriangles(4, 4, 32, 4);                                                                                              
            List<ComparisionPoint> points = Inputhandler.GetPoints("1,3,5; 4  , 13, 4;");
            //TESTING
            foreach (ComparisionPoint p in points)
            {
                Console.WriteLine(p.X + p.Y + p.PointScore);
            }
            List<IShape> shapes = Inputhandler.GetShapes("CIRCLE,   1,1,100;  TRIANGLE  , 2,3,123  ; ");
            Console.WriteLine(shapes.Count);
            
        }
    }

}