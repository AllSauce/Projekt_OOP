using System;

namespace ThiccShapes
{
    
    
    public class UserInputException : System.Exception
    {
        public UserInputException() 
        { 
            Console.WriteLine("User input Error!");
            Console.WriteLine("Exiting");
            Environment.Exit(1);
        }
        public UserInputException(string message) : base(message) { }
        public UserInputException(string message, System.Exception inner) : base(message, inner) { }
        protected UserInputException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}