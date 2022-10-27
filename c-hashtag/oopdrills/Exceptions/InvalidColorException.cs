using System;

namespace oopdrills.Exceptions
{
    public class InvalidColorException : Exception
    {
        public InvalidColorException() : base("Invalid Color. Please use a valid color.") { }
    }
}