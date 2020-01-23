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
            //Checks Equal
            Assert.AreEqual(12, obj.add(7, 5));

            //Checks Unequal
            Assert.AreNotEqual(14, obj.add(7, 5));
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
            //Checks Equal
            Assert.AreEqual(2, obj.sub(7, 5));

            //Checks Unequal
            Assert.AreNotEqual(14, obj.sub(7, 5));
        }

        [TestMethod]
        public void Mul_Test_ForCalculation()
        {
            //Checks Equal
            Assert.AreEqual(50, obj.mul(10, 5));

            //Checks Unequal
            Assert.AreNotEqual(40, obj.mul(7, 5));
        }

        [TestMethod]
        public void Div_Test_ForCalculation()
        {
            //Checks Equal
            Assert.AreEqual(14, obj.div(70, 5));

            //Checks Unequal
            Assert.AreNotEqual(14, obj.div(92, 5));
        }

        [TestMethod]
        public void Div_Test_Divide_By_Zero_Exception()
        {
            //checks for the Divide by zero exception
            Assert.ThrowsException<System.DivideByZeroException>(() => obj.div(8, 0));
        }
    }
}
