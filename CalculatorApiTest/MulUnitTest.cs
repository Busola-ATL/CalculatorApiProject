using StringLibrary;
using MyApp.Namespace;
namespace CalculatorApiTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_Multiply_TwoPositiveNumbers()
    {
        // Arrange
        var firstDigit = 5.5m;
        var secondDigit = 3.2m;
        var expected = 17.6m;

        // Act
        var result = Calculator.Multiply(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Multiply_PositiveAndNegativeNumber()
    {
        // Arrange
        var firstDigit = 10.5m;
        var secondDigit = -3.2m;
        var expected = -33.6m;

        // Act
        var result = Calculator.Multiply(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Multiply_TwoNegativeNumbers()
    {
        // Arrange
        var firstDigit = -2.5m;
        var secondDigit = -3.8m;
        var expected = 9.5m;

        // Act
        var result = Calculator.Multiply(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    public void Test_Multiply_ZeroAndPositiveNumber()
    {
        // Arrange
        var firstDigit = 0m;
        var secondDigit = 4.7m;
        var expected = 0m;

        // Act
        var result = Calculator.Multiply(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Multiply_ZeroAndNegativeNumber()
    {
        // Arrange
        var firstDigit = 0m;
        var secondDigit = -6.9m;
        var expected = 0m;

        // Act
        var result = Calculator.Multiply(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

}