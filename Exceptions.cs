using System;

namespace ThiccShapes
{
    
    
    public class UserInputException : System.Exception
    {
        public UserInputException() 
        { 
            
        }
        public UserInputException(string message) : base(message) 
        {
            Console.WriteLine(message);
            Environment.Exit(1);
        }
        public UserInputException(string message, System.Exception inner) : base(message, inner) { }
        protected UserInputException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}