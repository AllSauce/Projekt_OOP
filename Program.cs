using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public class Program
    {
        static void Main(string[] args)
        {  
            ScoreGetter a = new ScoreGetter();
            Console.WriteLine(a.GetScore(args));
        }
    }
}