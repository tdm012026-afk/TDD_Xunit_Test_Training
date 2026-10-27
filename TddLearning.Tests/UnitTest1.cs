using Xunit;

namespace TddLearning.Tests;

public class UnitTest1
{
    // [Fact]                   // First test 
    // public void Test1()
    // {
    //     Assert.True(true);
    // }

    [Fact]
    public void Add_TwoNumbers_ReturnSum()
    {
        var calculator = new Calculator();  // Missing Calculator class
        var result = calculator.Add(2, 3);

        Assert.Equal(5, result);
    }
}
