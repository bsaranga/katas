using System;

namespace oopdrills_tests
{
    internal class InvalidColorException : Exception
    {
        public InvalidColorException() : base("Invalid Color. Please use a valid color."){ }
    }
}