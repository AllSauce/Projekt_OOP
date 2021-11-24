namespace ThiccShapes
{
    class ScoreGetter
    {
        public double GetScore(string[] args)
        {
            Inputhandler ih = new Inputhandler();
            Algorithm a = new Algorithm();
            var t1 = ih.HandleInput(args, a);
            double counter = 0;
            foreach(Shape s in t1.Item2)
            {
                foreach(ComparisionPoint p in t1.Item1)
                {
                    if (s.Inside(p, a))
                    {
                        counter = counter + (s.getArea() * s.GetShapeScore() * p.PointScore);
                    }
                    else counter = counter + ((s.getArea() * s.GetShapeScore()) / 4);
                    
                }
            }
            return counter;
        }   
    }
    
}