using System;
using System.Collections.Generic;
using System.IO;

namespace ThiccShapes
{
    public static class Inputhandler
    {
        public static Tuple<List<ComparisionPoint>, List<Shape>> HandleInput(string[] args)
        {
            List<ComparisionPoint> points = GetPoints(args[0]);
            List<Shape> shapes = GetShapes(args[1]);
            ChangeShapreScores(args[2]);
            Tuple<List<ComparisionPoint>, List<Shape>> tuple = new Tuple<List<ComparisionPoint>, List<Shape>>(points, shapes);
            return tuple;
        }
        
        public static List<ComparisionPoint> GetPoints(string s)
        {
            string[] args = toStringArray(s);
            List<ComparisionPoint> points = new List<ComparisionPoint>();
            foreach(string strung in args)
            {               
                string[] stringArray = strung.Split(',');
                
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }                               
                try
                {
                    points.Add(new ComparisionPoint(Int32.Parse(stringArray[0]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));                    
                }
                catch
                {
                    throw new UserInputException();
                }                              
            }           
            return points;
        }
        static void ChangeShapreScores(string s)
        {
            string[] args = toStringArray(s);
            

            foreach(string arg in args)
            {
                string[] stringArray = arg.Split(',');                
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }
                try
                {
                    switch (stringArray[0])
                    {
                        case "CIRCLE":
                            Shape.setSC(Int32.Parse(stringArray[1]), 0);
                            break;
                        case "TRIANGLE" :
                            Shape.setSC(Int32.Parse(stringArray[1]), 1);
                            break;
                        case "SQUARE" :
                            Shape.setSC(Int32.Parse(stringArray[1]), 2);
                            break;
                        case "PENTAGON" :
                            Shape.setSC(Int32.Parse(stringArray[1]), 3);
                            break;
                        case "HEXAGON" : 
                            Shape.setSC(Int32.Parse(stringArray[1]), 4);
                            break;
                        case "HEPTAGON" :
                            Shape.setSC(Int32.Parse(stringArray[1]), 5);
                            break;
                        case "OCTAGON" :
                            Shape.setSC(Int32.Parse(stringArray[1]), 6);
                            break;
                        default :
                            throw new UserInputException("No shape called " + stringArray[0]);                         
                    }  
                }
                catch { throw new UserInputException(stringArray[1] + " Is not an integer"); }
            }
            
        }

        public static List<Shape> GetShapes(string s)
        {
            string[] args = toStringArray(s);
            
            List<Shape> Shapes = new List<Shape>();
            foreach(string strung in args)
            {                
                string[] stringArray = strung.Split(',');                
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }
                try
                {
                    switch (stringArray[0])
                    {
                        case "CIRCLE":
                            Shapes.Add(new Circle(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2]), Int32.Parse(stringArray[3])));
                            break;
                        case "TRIANGLE" :
                            Shapes.Add(new Triangle(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2]), Int32.Parse(stringArray[3])));
                            break;
                        case "SQUARE" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 4));
                            break;
                        case "PENTAGON" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 5));
                            break;
                        case "HEXAGON" : 
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 6));
                            break;
                        case "HEPTAGON" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 7));
                            break;
                        case "OCTAGON" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 8));
                            break;
                        default :
                            throw new UserInputException("No shape called " + stringArray[0]);                         
                    }  
                }
                catch { throw new UserInputException(stringArray[1] + " or " + stringArray[2] + " or " + stringArray[3] + " Is not an integer"); }            
            }
            return Shapes;
        }
        static string[] toStringArray(string s)
        {
            s = s.Trim(' ');
            s = s.Remove(s.Length - 1);
            return s.Split(';');
        }
        
    }
}