using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        CalculatorLibrary.CalculatorLibrary obj = new CalculatorLibrary.CalculatorLibrary();
        [TestMethod]
        public void Add_Test_ForCalculation()
        {
            //Arrange
            int firstValue = 7, secondValue = 5;

            //Act
            int result = obj.add(firstValue, secondValue);
            int wrongResult = 24;

            //Assert
            Assert.AreEqual(result, firstValue + secondValue);
            Assert.AreNotEqual(wrongResult, firstValue + secondValue);
        }

        [TestMethod]
        public void Add_Test_Overflow_Exception()
        {
            //Checks for the Overflow Exception
            Assert.ThrowsException<System.OverflowException>(() => obj.add(int.MaxValue, 21));
        }

        [TestMethod]
        public void Sub_Test_ForCalculation()
        {
            //Arrange
            int firstValue = 7, secondValue = 5;

            //Act
            int result = obj.sub(firstValue, secondValue);
            int wrongResult = 24;

            //Assert
            Assert.AreEqual(result, firstValue - secondValue);
            Assert.AreNotEqual(wrongResult, firstValue + secondValue);
        }

        [TestMethod]
        public void Mul_Test_ForCalculation()
        {
            //Arrange
            int firstValue = 7, secondValue = 5;

            //Act
            int result = obj.mul(firstValue, secondValue);
            int wrongResult = 24;

            //Assert
            Assert.AreEqual(result, firstValue * secondValue);
            Assert.AreNotEqual(wrongResult, firstValue + secondValue);
        }

        [TestMethod]
        public void Div_Test_ForCalculation()
        {
            //Arrange
            int firstValue = 10, secondValue = 5;

            //Act
            int result = obj.div(firstValue, secondValue);
            int wrongResult = 24;

            //Assert
            Assert.AreEqual(result, firstValue / secondValue);
            Assert.AreNotEqual(wrongResult, firstValue + secondValue);
        }

        [TestMethod]
        public void Div_Test_Divide_By_Zero_Exception()
        {
            //checks for the Divide by zero exception
            Assert.ThrowsException<System.DivideByZeroException>(() => obj.div(8, 0));
        }
    }
}
