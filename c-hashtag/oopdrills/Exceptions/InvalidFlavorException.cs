namespace oopdrills
{
    public class InvalidFlavorException : Exception
    {
        public InvalidFlavorException() : base("Invalid Flavor. Please use an accepted flavor.") { }
    }
}