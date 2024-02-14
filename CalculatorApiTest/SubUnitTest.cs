using StringLibrary;
namespace CalculatorApiTest;

[TestClass]
public class SubtractTest
{
    [TestMethod]
    public void Test_Subtract_TwoPositiveNumbers()
    {
        // Arrange
        var firstDigit = 10.5m;
        var secondDigit = 3.2m;
        var expected = 7.3m;

        // Act
        var result = CalclLogic.Subtract(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Subtract_PositiveAndNegativeNumber()
    {
        // Arrange
        var firstDigit = 10.5m;
        var secondDigit = -3.2m;
        var expected = 13.7m;

        // Act
        var result = CalclLogic.Subtract(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Subtract_TwoNegativeNumbers()
    {
        // Arrange
        decimal firstDigit = -2.5m;
        decimal secondDigit = -3.8m;
        decimal expected = 1.3m;

        // Act
        var result = CalclLogic.Subtract(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    public void Test_Subtract_ZeroAndPositiveNumber()
    {
        // Arrange
        decimal firstDigit = 0m;
        decimal secondDigit = 4.7m;
        decimal expected = -4.7m;

        // Act
        var result = CalclLogic.Subtract(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Subtract_ZeroAndNegativeNumber()
    {
        // Arrange
        decimal firstDigit = 0m;
        decimal secondDigit = -6.9m;
        decimal expected = 6.9m;

        // Act
        var result = CalclLogic.Subtract(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }
}