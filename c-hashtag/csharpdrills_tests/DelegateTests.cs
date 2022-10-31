using csharpdrills;
using Xunit;
using Xunit.Abstractions;

namespace csharpdrills_tests;

public class DelegateTests
{
    private readonly ITestOutputHelper testOutputHelper;

    public DelegateTests(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void ComparatorDelegate_Returns_1_When_Left_Lesser_Than_Right()
    {
        var del = new DelegatesAndEvents();
        Assert.Equal(1, del.Comparator(5,6));
    }

    [Fact]
    public void ComparatorDelegate_Lambda_Definition_Returns_Neg1_When_Left_Greater_Than_Right()
    {
        var del = new DelegatesAndEvents(true);
        Assert.Equal(-1, del.Comparator(7,2));
    }

    [Fact]
    public void Comparator_Has_More_Than_One_Targets() 
    {
        var del = new DelegatesAndEvents(null, true);
        Assert.True(del.Comparator.GetInvocationList().Length > 1);
    }
}