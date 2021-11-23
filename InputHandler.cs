using System;
using System.Collections.Generic;
using System.IO;

namespace ThiccShapes
{
    public static class Inputhandler
    {
        public static Tuple<List<ComparisionPoint>, List<IShape>> HandleInput(string[] args)
        {
            List<ComparisionPoint> points = GetPoints(args[0]);
            List<IShape> shapes = GetShapes(args[1]);
            Tuple<List<ComparisionPoint>, List<IShape>> tuple = new Tuple<List<ComparisionPoint>, List<IShape>>(points, shapes);
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