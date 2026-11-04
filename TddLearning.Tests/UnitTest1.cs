using System.Diagnostics.CodeAnalysis;
using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace TddLearning.Tests;

public class UnitTest1
{
    // // [Fact]                   // First test 
    // // public void Test1()
    // // {
    // //     Assert.True(true);
    // // }

    // [Fact]                  //second test 
    // public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    // {
    //     var calculator = new Calculator();  
    //     var result = calculator.Add(2, 3);

    //     Assert.Equal(5, result);

    //     Console.WriteLine($"Result: {result}");

    // }
    // [Fact]              //Third Test
    // public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    // {
    //     //Arrange
    //     var calculator = new Calculator();

    //     //Act
    //     var result = calculator.Add(-2, -3);

    //     // Assert
    //     Assert.Equal(-5, result);

    //     // Display result 
    //     Console.WriteLine($"Result: {result}");
    // }
    // [Theory]
    // [InlineData(2, 3, 5)]
    // [InlineData(-2, -3, -5)]
    // [InlineData(10, 5, 15)]
    // [InlineData(0, 5, 5)]
    // public void Add_Numbers_ReturnsCorrectSum(int a, int b, int expected)
    // {
    //     // Arrange
    //     var calculator = new Calculator();

    //     //Act
    //     var result = calculator.Add(a, b);

    //     //Assert 
    //     Assert.Equal(expected, result);
    // }
    // [Theory]
    // [InlineData(2, 3, 5)]
    // [InlineData(-2, -3, -5)]
    // [InlineData(0, 5, 5)]
    // public void Add_Numbers_ReturnCorrectSum(int a, int b, int expected)
    // {
    //     //Arrange 
    //     var calculator = new Calculator();

    //     //Act
    //     var result = calculator.Add(a, b);

    //     //Assert
    //     Assert.Equal(expected, result);

    //     Console.WriteLine($":: Result :: {result}");
    
    // }
    // [Fact]
    // public void Divide_ByZero_ThrowsException()
    // {
    //     //Arrange
    //     var calculator = new Calculator();

    //     //Act & Assert
    //     Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    
    // }
    // [Theory]
    // [InlineData(10, 2, 5)]
    // [InlineData(-10, -2, 5)]
    // [InlineData(0, 5, 0)]
    // public void Divide_Numbers_ReturnCorrectResult(int a, int b, int expected)
    // {
    //     //Arrange
    //     var calculator = new Calculator();

    //     //Act
    //     var result = calculator.Divide(a, b);

    //     // Assert
    //     Assert.Equal(expected, result);
    // }
    // [Theory]
    // [InlineData(5, 5, 25)]
    // [InlineData(6, 6, 36)]
    // [InlineData(7, 7, 49)]
    // public void Multiply_Numbers_ReturnCorrectResult(int a, int b, int expected)
    // {
    //     //Arrange
    //     var calculator = new Calculator();

    //     //Act 
    //     var result = calculator.Multiply(a, b);

    //     //Assert
    //     Assert.Equal(expected, result);

    // }
    // [Fact]
    // public void Multiply_TwoNumbers_ReturnCorrectSum()
    // {
    //     var calculator = new Calculator();

    //     var result = calculator.Multiply(4, 5);

    //      Assert.Equal(20, result);
    // }
    // [Fact]
    // public void Divide_ByZero_ThrowsException()
    //     {
    //         //Arrange
    //         var calculator = new Calculator();

    //         // Act & Assert
    //         Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    //     }
    [Fact]
    public void Divide_ByTwo_ReturnCorrectSum()
    {
        //Arrange 
        var calculator = new Calculator();

        // Act & Assert

        var result = calculator.Divide(10, 2);

        Assert.Equal(5, result);

    }

}
