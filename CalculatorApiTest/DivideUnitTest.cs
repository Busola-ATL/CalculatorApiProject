using StringLibrary;
using MyApp.Namespace;
namespace CalculatorApiTest;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void Test_Divide_ZeroByNonZeroNumber()
    {
        // Arrange
        var firstDigit = 0m;
        var secondDigit = 4.7m;
        var expected = 0m;

        // Act
        var result = Calculator.Divide(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Divide_NegativeNumberByNonZeroNumber()
    {
        // Arrange
        var firstDigit = -6.9m;
        var secondDigit = 2.5m;
        var expected = -2.76m;

        // Act
        var result = Calculator.Divide(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Divide_NonZeroNumberByNegativeNumber()
    {
        // Arrange
        var firstDigit = 3.2m;
        var secondDigit = -1.6m;
        var expected = -2m;

        // Act
        var result = Calculator.Divide(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Divide_TwoNonZeroNumbers()
    {
        // Arrange
        var firstDigit = 10.5m;
        var secondDigit = 2.0m;
        var expected = 5.25m;

        // Act
        var result = calculator.Divide(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    public void Test_Divide_ByZero()
    {
        // Arrange
        var firstDigit = 8.0m;
        var secondDigit = 0m;
        var expected = "Error!!";

        // Act
        var result = Calculator.Divide(firstDigit, secondDigit);

        // Assert
        Assert.AreEqual(expected, result);
}



}