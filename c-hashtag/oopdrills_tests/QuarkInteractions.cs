using oopdrills;
using oopdrills.Exceptions;
using Xunit;
using Xunit.Abstractions;

namespace oopdrills_tests
{
    /*
    You're modelling the interaction between a large number of quarks and have decided to create a Quark class
    so you can generate your own quark objects.

    Quarks are fundamental particles and the only fundamental particle to experience all four fundamental forces.

    Your task
    1. Your Quark class should allow you to create quarks of any valid color 
       ("red", "blue", and "green") and any valid flavor ('up', 'down', 'strange', 'charm', 'top', and 'bottom').

    2. Every quark has the same baryon_number (BaryonNumber in C#): 1/3.

    3. Every quark should have an .interact() (.Interact() in C#) method that allows any quark to interact with 
       another quark via the strong force. When two quarks interact they exchange colors.
    */

    public class QuarkInteractions
    {
        private readonly ITestOutputHelper output;

        public QuarkInteractions(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(new string[] {"red", "blue", "green"}, new string[] {"up", "down", "strange", "charm", "top", "bottom"})]
        public void Allows_Quark_To_Be_Created_With_Any_Valid_Color_And_Flavor(string[] validColors, string[] validFlavors)
        {
            foreach (var color in validColors)
            {
                foreach (var flavor in validFlavors)
                {
                    var quark = new Quark(color, flavor);
                    Assert.IsType<Quark>(quark);
                }
            }
        }

        [Fact]
        public void Throws_Invalid_Color_Exception_When_Created_With_Invalid_Color()
        {
            // Arrange
            var invalidColor = "purple";
            var validFlavor = "up";

            Assert.Throws<InvalidColorException>(() => new Quark(invalidColor, validFlavor));
        }

        [Fact]
        public void Throws_Invalid_Flavor_Exception_When_Created_With_Invalid_Flavor()
        {
            // Arrange
            var validColor = "red";
            var invalidFlavor = "butter";

            Assert.Throws<InvalidFlavorException>(() => new Quark(validColor, invalidFlavor));
        }

        [Fact]
        public void All_Quarks_Have_The_Same_Baryon_Number()
        {
            // Arrange
            var quark = new Quark("red", "up");
            float expectedBaryonNumber = 1/3f;

            Assert.Equal(expectedBaryonNumber, quark.BaryonNumber);
        }

        [Fact]
        public void Exchanges_Color_On_Interact()
        {
            // Arrange
            var q1 = new Quark("red", "up");
            var q2 = new Quark("green", "bottom");

            // Act
            q1.Interact(q2);

            // Assert
            Assert.Equal("green", q1.Color);
            Assert.Equal("red", q2.Color);
        }
    }
}