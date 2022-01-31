using Calculator_WebApi.Core;
using Calculator_WebApi.Services.Realizations;
using NUnit.Framework;
using System;

namespace Calculator_WebApi.Tests.Calculator_WebApi.Services
{
    [TestFixture]
    public class MathOperationTests
    {
        [Test]
        [TestCase(10, 15, "+", ExpectedResult = 25)]
        [TestCase(50, -32, "-", ExpectedResult = 82)]
        [TestCase(82, -9, "/", ExpectedResult = -9)]
        [TestCase(108, 10, "*", ExpectedResult = 1080)]
        public int DoMathOperationTest(int x, int y, string mathOperator)
        {
            //Arrange
            var mathOperation = new MathOperationService();
            var calculatorEntity = new CalculatorEntity() { X = x, Y = y, MathOperator = mathOperator};
            
            //Act
            var result = mathOperation.DoMathOperation(calculatorEntity);

            //Assert
            return result;
        }


        [Test]
        public void DoMathOperationDivisionByZeroExceptionTest()
        {
            // Arrange
            var mathOperation = new MathOperationService();

            // Act - Assert
            Assert.Throws<DivideByZeroException>(() => mathOperation.DoMathOperation(new CalculatorEntity()
            {
                X = 10,
                Y = 0,
                MathOperator = "/"
            }));

            // Assert
            // Assert.AreEqual(5, result);
        }


        [Test]
        [TestCase(1, 1, "qw")]
        [TestCase(1, 1, "/*")]
        [TestCase(1, 1, "**")]
        [TestCase(1, 1, "++")]
        [TestCase(1, 1, "")]
        public void DoMathOperationIncorrectMathOperatorExceptionTest(int x, int y, string mathOperator)
        {
            // Arrange
            var mathOperation = new MathOperationService();

            // Act - Assert
            Assert.Throws<InvalidOperationException>(() => mathOperation.DoMathOperation(new CalculatorEntity()
            {
                X = x,
                Y = x,
                MathOperator = mathOperator
            }));

            // Assert
            // Assert.AreEqual(5, result);
        }


    }
}
