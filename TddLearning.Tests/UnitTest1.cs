using Xunit;

namespace TddLearning.Tests;

public class UnitTest1
{
    // [Fact]                   // First test 
    // public void Test1()
    // {
    //     Assert.True(true);
    // }

    [Fact]                  //second test 
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        var calculator = new Calculator();  
        var result = calculator.Add(2, 3);

        Assert.Equal(5, result);

        Console.WriteLine($"Result: {result}");

    }
    [Fact]              //Third Test
    public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var result = calculator.Add(-2, -3);

        // Assert
        Assert.Equal(-5, result);

        // Display result 
        Console.WriteLine($"Result: {result}");
    }
}
