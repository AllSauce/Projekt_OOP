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
            s = s.Trim(' ');
            s = s.Remove(s.Length - 1);
            string[] args = s.Split(';');
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
            s = s.Trim(' ');
            s = s.Remove(s.Length - 1);
            string[] args = s.Split(';');

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
                            Circle.ShapeScore = Int32.Parse(stringArray[1]);
                            break;
                        case "TRIANGLE" :
                            Triangle.ShapeScore = Int32.Parse(stringArray[1]);
                            break;
                        case "SQUARE" :
                            Sqaure.ShapeScore = Int32.Parse(stringArray[1]);
                            break;
                        case "PENTAGON" :
                            Pentagon.ShapeScore = Int32.Parse(stringArray[1]);
                            break;
                        case "HEXAGON" : 
                            Hexagon.ShapeScore = Int32.Parse(stringArray[1]);
                            break;
                        case "HEPTAGON" :
                            Heptagon.ShapeScore = Int32.Parse(stringArray[1]);
                            break;
                        case "OCTAGON" :
                            Octagon.ShapeScore = Int32.Parse(stringArray[1]);
                            break;
                        default :
                            throw new UserInputException();                         
                    }  
                }
                catch { throw new UserInputException(); }
            }
            
        }

        public static List<Shape> GetShapes(string s)
        {
            s = s.Trim(' ');
            s = s.Remove(s.Length - 1);
            string[] args = s.Split(';');
            
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
                            Shapes.Add(new Sqaure(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2]), Int32.Parse(stringArray[3])));
                            break;
                        case "PENTAGON" :
                            Shapes.Add(new Pentagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2]), Int32.Parse(stringArray[3])));
                            break;
                        case "HEXAGON" : 
                            Shapes.Add(new Hexagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2]), Int32.Parse(stringArray[3])));
                            break;
                        case "HEPTAGON" :
                            Shapes.Add(new Heptagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2]), Int32.Parse(stringArray[3])));
                            break;
                        case "OCTAGON" :
                            Shapes.Add(new Octagon(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2]), Int32.Parse(stringArray[3])));
                            break;
                        default :
                            throw new UserInputException();                         
                    }  
                }
                catch { throw new UserInputException(); }            
            }
            return Shapes;
        }
        
    }
}