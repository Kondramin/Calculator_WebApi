using Calculator_WebApi.Controllers;
using Calculator_WebApi.Core;
using Calculator_WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Calculator_WebApi.Tests.Calculator_WebApi
{
    [TestFixture]
    public class CalculatorControllerTests
    {
        [Test]
        public void PostIsNotNullTest()
        {
            //Arrange
            var calculatorController = new CalculatorController(CreatMock().Object);

            //Act
            var result = calculatorController.Post(new Calculator());


            //Assert
            Assert.IsNotNull(result);
        }


        [Test]
        public void postreturnvalusetest()
        {
            //Arrange
            var calculatorcontroller = new CalculatorController(CreatMock().Object);
            var expected = 999;

            //Act
            var result = calculatorcontroller.Post(new Calculator());

            ObjectResult objectResult = result.Result.Result as ObjectResult;


            //Assert
            Assert.AreEqual(expected, (Int32)objectResult.Value);
        }



        private Mock<IMathOperationService> CreatMock()
        {
            var mock = new Mock<IMathOperationService>();
            mock.Setup(s => s.DoMathOperation(It.IsAny<Calculator>())).Returns(999);

            return mock;
        }
    }
}
