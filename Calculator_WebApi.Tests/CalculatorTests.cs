using Calculator_WebApi.Core;
using NUnit.Framework;

namespace Calculator_WebApi.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(10, 10, ExpectedResult = 20)]
        [TestCase(15, 12, ExpectedResult = 27)]
        [TestCase(50, -1, ExpectedResult = 49)]
        [TestCase(12, -50, ExpectedResult = -38)]
        public int SumResultTest(int x, int y)
        {
            // Arrange
            var calculator = new Calculator() { X = x, Y = y };
            
            // Act
            var result = calculator.Sum();

            // Assert
            //Assert.AreEqual(120, result);
            return result;
        }


        [Test]
        [TestCase(1, 1, ExpectedResult = 0)]
        [TestCase(10, 8, ExpectedResult = 2)]
        [TestCase(15, 25, ExpectedResult = -10)]
        [TestCase(50, -1, ExpectedResult = 51)]
        [TestCase(12, -50, ExpectedResult = 62)]
        public int DifferenceResultTest(int x, int y)
        {
            // Arrange
            var calculator = new Calculator() { X = x, Y = y };
            
            // Act
            var result = calculator.Difference();

            // Assert
            //Assert.AreEqual(80, result);
            return result;
        }


        [Test]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(10, 8, ExpectedResult = 80)]
        [TestCase(15, 25, ExpectedResult = 375)]
        [TestCase(50, 0, ExpectedResult = 0)]
        [TestCase(12, -50, ExpectedResult = -600)]
        public int MultipliResultTest(int x, int y)
        {
            // Arrange
            var calculator = new Calculator() { X = x, Y = y };
            
            // Act
            var result = calculator.Multipli();

            // Assert
            //Assert.AreEqual(2000, result);
            return result;
        }


        [Test]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(10, 5, ExpectedResult = 2)]
        [TestCase(15, 25, ExpectedResult = 0)]
        [TestCase(50, 5, ExpectedResult = 10)]
        [TestCase(12, -4, ExpectedResult = -3)]
        public int DivisionResultTest(int x, int y)
        {
            // Arrange
            var calculator = new Calculator() { X = x, Y = y };
            
            // Act
            var result = calculator.Division();

            // Assert
            //Assert.AreEqual(5, result);
            return result;
        }
    }
}
