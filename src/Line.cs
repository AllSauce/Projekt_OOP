using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    //Datatype to more easily represent lines
    public class Line
    {
        
        public Point P1 {get; private set;}
        public Point P2 {get; private set;}
        
        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }
    }
}