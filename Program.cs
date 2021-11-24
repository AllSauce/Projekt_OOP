using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Program
    {
        static void Main(string[] args)
        {   
            string[] urgs = {"1, 1,5 ;", "SQUARE , 5,3 ,10 ;", 	" SQUARE, 5;"};
            Console.WriteLine(Algorithm.PointsGet(Inputhandler.HandleInput(urgs)));
        }
    }
}