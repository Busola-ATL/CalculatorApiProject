using StringLibrary;

namespace CalculatorApiTest;

[TestClass]
public class AddUnitTest
{
    [TestMethod]
    public void Test_Add_TwoPositiveNumbers()
    {
        var firstDigit = 5.5m;
        var secondDigit = 3.2m;
        var expected = 8.7m;

        var result = CalclLogic.Add(firstDigit, secondDigit);

    // Assert
        Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_Add_PositiveAndNegativeNumber()
        {
            // Arrange
            var firstDigit = 10.5m;
            var secondDigit = -3.2m;
            var expected = 7.3m;

            // Act
            var result = CalclLogic.Add(firstDigit, secondDigit);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_Add_TwoNegativeNumbers()
        {
            // Arrange
            var firstDigit = -2.5m;
            var secondDigit = -3.8m;
            var expected = -6.3m;

            // Act
            var result = CalclLogic.Add(firstDigit, secondDigit);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_Add_ZeroAndPositiveNumber()
        {
            // Arrange
            var firstDigit = 0m;
            var secondDigit = 4.7m;
            var expected = 4.7m;

            // Act
            var result = CalclLogic.Add(firstDigit, secondDigit);

            // Assert
            Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void Test_Add_ZeroAndNegativeNumber()
            {
                // Arrange
                decimal firstDigit = 0m;
                decimal secondDigit = -6.9m;
                decimal expected = -6.9m;

                // Act
                var result = CalclLogic.Add(firstDigit, secondDigit);

                // Assert
                Assert.AreEqual(expected, result);
            }
}