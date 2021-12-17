using System;
using System.Collections.Generic;
using System.IO;

namespace ThiccShapes
{
    public class Inputhandler
    {
        public Tuple<List<ComparisionPoint>, List<Shape>> HandleInput(string[] args, Algorithm a, ShapeScore sc)
        {
            //Gets points into list with use of first string in args
            List<ComparisionPoint> points = GetPoints(args[0]);

            //Gets shapes into a list with use of second string in args
            List<Shape> shapes = GetShapes(args[1], a);

            //Updates shapescores depending on what is said within third string in args
            ChangeShapreScores(args[2], sc);

            //Checks that all used shapes have a shapescore
            foreach (Shape s in shapes)
            {
                if (s.GetShapeScore(sc) == 0)
                {   
                    throw new UserInputException("One or more shapes lacks associtaed ShapeScore");
                }
            }
            // Prepares to return
            return new Tuple<List<ComparisionPoint>, List<Shape>>(points, shapes);
        }
        //Gets point from input string
        public List<ComparisionPoint> GetPoints(string s)
        {
            // Splits string between ; and trims away ' '
            string[] args = toStringArray(s);

            //returnlist
            List<ComparisionPoint> points = new List<ComparisionPoint>();

            foreach(string strung in args)
            {     
                //Splits string into every argument needed         
                string[] stringArray = strung.Split(',');
                
                //Removes all spaces for parsing
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }                               
                try
                {
                    //Adds a new point
                    points.Add(new ComparisionPoint(Int32.Parse(stringArray[0]), Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])));                    
                }
                //Cathces if parsing fails
                catch
                {
                    throw new UserInputException("Your input for the points is incorrect. It should follow this format: X, Y, SCORE. Each point should also be separated with a ‘;’");     
                }                              
            }           
            return points;
        }
        void ChangeShapreScores(string s, ShapeScore sc)
        {
            // Splits string between ; and trims away ' '
            string[] args = toStringArray(s);
            

            foreach(string arg in args)
            {
                //Splits between different arguments
                string[] stringArray = arg.Split(',');  

                //Trims for parsing              
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }
                try
                {
                    switch (stringArray[0])
                    {
                        case "CIRCLE":
                            sc.setSC(Int32.Parse(stringArray[1]), 0);
                            break;
                        case "TRIANGLE" :
                            sc.setSC(Int32.Parse(stringArray[1]), 1);
                            break;
                        case "SQUARE" :
                            sc.setSC(Int32.Parse(stringArray[1]), 2);
                            break;
                        case "PENTAGON" :
                            sc.setSC(Int32.Parse(stringArray[1]), 3);
                            break;
                        case "HEXAGON" : 
                            sc.setSC(Int32.Parse(stringArray[1]), 4);
                            break;
                        case "HEPTAGON" :
                            sc.setSC(Int32.Parse(stringArray[1]), 5);
                            break;
                        case "OCTAGON" :
                            sc.setSC(Int32.Parse(stringArray[1]), 6);
                            break;
                        default :
                            // If it doesn't  match any implemented shape
                            throw new UserInputException("No shape called " + stringArray[0]);                         
                    }  
                }
                //Cathces if parsing fails
                catch 
                {
                    try
                    {
                        throw new UserInputException(stringArray[1] + " Is not an integer"); 
                    }
                    catch 
                    {                        
                        throw new UserInputException("Shapescore for " + stringArray[0] + " can't be blank or null");
                    }
                }
            }
            
        }
        //Gets shapoes from input string
        public List<Shape> GetShapes(string s, Algorithm a)
        {
            //Splits string into the different shapes
            string[] args = toStringArray(s);

            //Return List
            List<Shape> Shapes = new List<Shape>();

            foreach(string strung in args)
            {       
                //Splits between different arguments         
                string[] stringArray = strung.Split(','); 

                //Trims for parsing               
                for(int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = stringArray[i].Trim(' ');
                }
                try
                {
                    switch (stringArray[0])
                    {
                        case "CIRCLE":
                            Shapes.Add(new Circle(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3])));
                            break;
                        case "TRIANGLE" :
                            Shapes.Add(new Triangle(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), a));
                            break;
                        case "SQUARE" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 4, a));
                            break;
                        case "PENTAGON" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 5, a));
                            break;
                        case "HEXAGON" : 
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 6, a));
                            break;
                        case "HEPTAGON" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 7, a));
                            break;
                        case "OCTAGON" :
                            Shapes.Add(new Polygon(new Point(Int32.Parse(stringArray[1]), Int32.Parse(stringArray[2])), Int32.Parse(stringArray[3]), 8, a));
                            break;
                        default :
                            // Catches if input doesn't match any implemented shape
                            throw new UserInputException("No shape called " + stringArray[0]);                         
                    }  
                }
                //Cathes if parsing fails
                catch
                { 
                    if (stringArray.Length == 4)
                    throw new UserInputException(stringArray[1] + " or " + stringArray[2] + " or " + stringArray[3] + " Is not an integer"); 
                    else throw new UserInputException("Arguments for creating a shape are missing");
                    
                }             
            }
            return Shapes;
        }
        //Helper method to splits between ;
        string[] toStringArray(string s)
        {
            s = s.Trim(' ');
            //Removes last ; if one exists
            if(s[s.Length - 1] == ';') s = s.Remove(s.Length - 1);
            return s.Split(';');
        }
        
    }
}