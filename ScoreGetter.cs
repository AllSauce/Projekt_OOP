using System;

namespace ThiccShapes
{
    //Coordinates classes to return a score
    class ScoreGetter
    {
            Inputhandler ih = new Inputhandler();
            Algorithm a = new Algorithm();
            ShapeScore sc = new ShapeScore();
        public double GetScore(string[] args)
        {
            //Creating instances of classes
            

            //Gets list of shapes and compPoints and from injecting input, an algorithm and a shapescore so that inputhandler can change it
            var t1 = ih.HandleInput(args, a, sc);

            //Return double
            double counter = 0;
            
            //Checks every shape against every Comppoint and adds score accordingly
            foreach(Shape s in t1.Item2)
            {
                foreach(ComparisionPoint p in t1.Item1)
                {
                    if (s.Inside(p, a))
                    {
                        counter = counter + (s.getArea() * s.GetShapeScore(sc) * p.PointScore);
                    }
                    else counter = counter + ((s.getArea() * s.GetShapeScore(sc)) / 4);
                    
                }
            }
            //Returns rounded answer
            return Math.Round(counter, MidpointRounding.AwayFromZero);

        }   
    }
    
}