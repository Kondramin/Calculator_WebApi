using Calculator_WebApi.Core;
using NUnit.Framework;
using System;

namespace Calculator_WebApi.Tests.Calculator_WebApi.Core
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(50, -1, ExpectedResult = 49)]
        public int SumResultTest(int x, int y)
        {
            // Arrange
            var calculator = new CalculatorLogic();

            // Act
            var result = calculator.Summ(x, y);

            // Assert
            //Assert.AreEqual(120, result);
            return result;
        }


        [Test]
        [TestCase(12, -50, ExpectedResult = 62)]
        public int DifferenceResultTest(int x, int y)
        {
            // Arrange
            var calculator = new CalculatorLogic();

            // Act
            var result = calculator.Difference(x, y);

            // Assert
            //Assert.AreEqual(80, result);
            return result;
        }


        [Test]
        [TestCase(12, -50, ExpectedResult = -600)]
        public int MultipliResultTest(int x, int y)
        {
            // Arrange
            var calculator = new CalculatorLogic();

            // Act
            var result = calculator.Multipli(x, y);

            // Assert
            //Assert.AreEqual(2000, result);
            return result;
        }


        [Test]
        [TestCase(10, 5, ExpectedResult = 2)]
        public int DivisionResultTest(int x, int y)
        {
            // Arrange
            var calculator = new CalculatorLogic();

            // Act
            var result = calculator.Division(x, y);

            // Assert
            //Assert.AreEqual(5, result);
            return result;
        }

        [Test]
        public void DivisionByZeroResultExceptionTest()
        {
            // Arrange
            var calculator = new CalculatorLogic();

            // Act - Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10 ,0));

            // Assert
           // Assert.AreEqual(5, result);
        }
    }
}
