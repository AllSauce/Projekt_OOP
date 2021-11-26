using System;

namespace ThiccShapes
{
    class ScoreGetter
    {
        public double GetScore(string[] args)
        {
            Inputhandler ih = new Inputhandler();
            Algorithm a = new Algorithm();
            ShapeScore sc = new ShapeScore();
            var t1 = ih.HandleInput(args, a, sc);
            double counter = 0;
            
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
            return Math.Round(counter, MidpointRounding.AwayFromZero);
;
        }   
    }
    
}