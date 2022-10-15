using System;

namespace oopdrills_tests
{
    internal class InvalidFlavorException : Exception
    {
        public InvalidFlavorException() : base("Invalid Flavor. Please use an accepted flavor.")
        {
        }
    }
}