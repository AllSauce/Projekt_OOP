using System;
using System.Collections.Generic;

namespace ThiccShapes
{
    public static class Inputhandler
    {
        //public static Tuple<List<Point>, List<IShape>> HandleInput()
        //{
            
            
        //}
        
        public static List<Point> GetPoints(string s)
        {
            s = s.Trim(' ');
            s = s.Remove(s.Length - 1);
            string[] args = s.Split(';');
            List<Point> points = new List<Point>();
            foreach(string strung in args)
            {               
                string[] stringArray = strung.Split(',');
                
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }                               
                try
                {
                    points.Add(new Point(Int32.Parse(stringArray[0]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                    
                }
                catch
                {
                    throw new UserInputException();
                }                              
            }           
            return points;
        }

        public static List<IShape> GetShapes(string s)
        {
            s = s.Trim(' ');
            s = s.Remove(s.Length - 1);
            string[] args = s.Split(';');
            
            List<IShape> Shapes = new List<IShape>();
            foreach(string strung in args)
            {                
                string[] stringArray = strung.Split(',');                
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }
                switch (stringArray[0])
                {
                    case "CIRCLE":
                        Shapes.Add(new Circle(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                        break;
                    case "TRIANGLE" :
                        Shapes.Add(new Triangle(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                        break;
                    case "SQUARE" :
                        Shapes.Add(new Sqaure(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                        break;
                    case "PENTAGON" :
                        Shapes.Add(new Pentagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                            break;
                    case "HEXAGON" : 
                        Shapes.Add(new Hexagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                        break;
                    case "HEPTAGON" :
                        Shapes.Add(new Heptagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                        break;
                    case "OCTAGON" :
                        Shapes.Add(new Octagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));
                        break;
                    default :
                        throw new UserInputException();                         
                }                  
            }
            return Shapes;
        }
        
    }
}