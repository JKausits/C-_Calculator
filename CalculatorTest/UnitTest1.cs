using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNumber()
        {
            //Arrange
            var calculator = new CalculatorProgram();
            calculator.numberButtons("1");

            //Act
            string expected = "1";

            //Assert
            Assert.AreEqual(calculator.resultString, expected);

        }

        [TestMethod]
        public void AddZeroTest() {
            //Arrange
            var calculator = new CalculatorProgram();
        }
    }
}
