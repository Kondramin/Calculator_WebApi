using Calculator_WebApi.Controllers;
using Calculator_WebApi.Core;
using Calculator_WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
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


        //[Test]
        //public void PostReturnValuseTest()
        //{
        //    //Arrange
        //    var calculatorController = new CalculatorController(CreatMock().Object);
        //    Task<ActionResult<int>> expected = calculatorController.Post(new Calculator());

        //    //Act
        //    var result = calculatorController.Post(new Calculator());


        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}



        private Mock<IMathOperationService> CreatMock()
        {
            var mock = new Mock<IMathOperationService>();
            mock.Setup(s => s.DoMathOperation(new Calculator())).Returns(999);

            return mock;
        }
    }
}
