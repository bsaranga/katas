using oopdrills.Exceptions;

namespace oopdrills
{
    public class Quark
    {
        private readonly List<string> AcceptedColors = new List<string> { "red", "blue", "green" };
        private readonly List<string> AcceptedFlavors = new List<string> { "up", "down", "strange", "charm", "top", "bottom" };

        public string Color { get; internal set; }
        public string Flavor { get; private set; }
        public float BaryonNumber { get; } = 1/3f;

        public Quark(string color, string flavor)
        {
            if (!AcceptedColors.Contains(color)) throw new InvalidColorException();
            else this.Color = color;
            
            if (!AcceptedFlavors.Contains(flavor)) throw new InvalidFlavorException();
            else this.Flavor = flavor;
        }

        public void Interact(Quark quark)
        {
            var thisColor = Color;
            Color = quark.Color;
            quark.Color = thisColor;
        }
    }
}