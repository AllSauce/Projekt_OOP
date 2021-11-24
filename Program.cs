using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(Algorithm.PointsGet(Inputhandler.HandleInput(args)));
        }
    }
}