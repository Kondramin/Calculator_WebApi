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
        [TestCase(1, 1, "+", ExpectedResult = 2)]
        [TestCase(10, 15, "+", ExpectedResult = 25)]
        [TestCase(9, 100, "+", ExpectedResult = 109)]
        [TestCase(1, 1, "-", ExpectedResult = 0)]
        [TestCase(50, -32, "-", ExpectedResult = 82)]
        [TestCase(20, 43, "-", ExpectedResult = -23)]
        [TestCase(1, 1, "/", ExpectedResult = 1)]
        [TestCase(18, 9, "/", ExpectedResult = 2)]
        [TestCase(82, -9, "/", ExpectedResult = -9)]
        [TestCase(1, 1, "*", ExpectedResult = 1)]
        [TestCase(108, 10, "*", ExpectedResult = 1080)]
        [TestCase(12, -12, "*", ExpectedResult = -144)]
        public int DoMathOperationTest(int x, int y, string mathOperator)
        {
            //Arrange
            var mathOperation = new MathOperation();

            //Act
            var result = mathOperation.DoMathOperation(new Calculator() 
            {
                X = x,
                Y = y,
                MathOperator = mathOperator
            });

            //Assert
            return result;
        }


        [Test]
        public void DoMathOperationDivisionByZeroExceptionTest()
        {
            // Arrange
            var mathOperation = new MathOperation();

            // Act - Assert
            Assert.Throws<DivideByZeroException>(() => mathOperation.DoMathOperation(new Calculator()
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
            var mathOperation = new MathOperation();

            // Act - Assert
            Assert.Throws<InvalidOperationException>(() => mathOperation.DoMathOperation(new Calculator()
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
