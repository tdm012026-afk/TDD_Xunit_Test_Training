using System.Runtime.CompilerServices;
using Xunit;

namespace TddLearning.Tests;

public class UnitTest1
{
    [Theory]                    //ADD
    [InlineData(2, 3, 5)]
    [InlineData(-2, -3, -5)]
    [InlineData(0, 5, 5)]
    public void Add_Numbers_ReturnCorrectResult(int a, int b, int expected)
    {
        //Arrange 
        var calculator = new Calculator();

        //Act
        var result = calculator.Add(a, b);

        //Assert
        Assert.Equal(expected, result);

        Console.WriteLine($":: Result :: {result}");
    
    }
    [Theory]                        // SUBTRACT
    [InlineData(10, 4, 6)]
    [InlineData(5, 8, -3)]
    [InlineData(-5, -3, -2)]

    public void Subtract_Numbers_ReturnCorrectResult(int a, int b, int expected)
    {
        //Arrange
        var calculator = new Calculator();

        //Act 
        var result = calculator.Subtract(a, b);

        //Assert 
        Assert.Equal(expected, result);
    }

    
    [Theory]                     // MULTIPLY
    [InlineData(5, 5, 25)]
    [InlineData(6, 6, 36)]
    [InlineData(7, 7, 49)]
    public void Multiply_Numbers_ReturnCorrectResult(int a, int b, int expected)
    {
        //Arrange
        var calculator = new Calculator();

        //Act 
        var result = calculator.Multiply(a, b);

        //Assert
        Assert.Equal(expected, result);

    }
    
    [Theory]                       //DIVIDE
    [InlineData(10, 2, 5)]
    [InlineData(-10, -2, 5)]
    [InlineData(0, 5, 0)]
    public void Divide_Numbers_ReturnCorrectResult(int a, int b, int expected)
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var result = calculator.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]                       //DIVIDE
    public void Divide_ByZero_ThrowsException()
    {
        //Arrange
        var calculator = new Calculator();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
    [Theory]
    [InlineData(5, 25)]
    [InlineData(3, 9)]
    [InlineData(-4, 16)]
    public void Square_Number_ReturnsCorrectResult(int number, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Square(number);

        Assert.Equal(expected, result);
    }
    
}
