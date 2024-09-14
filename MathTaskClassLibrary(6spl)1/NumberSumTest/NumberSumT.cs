using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSumTest
{
    [TestClass]
    public class NumberSumT
    {
        [TestMethod]
        public void NumberSumValidDataTest()
        {
            var numberSum = new MathTaskClassLibrary.Class1.NumberSum();
            Assert.AreEqual(6, numberSum.SumOfNumber("123"));
            Assert.AreEqual(39, numberSum.SumOfNumber("456789"));
        }

        [TestMethod]
        public void NumberSumInvalidDataTest()
        {
            var numberSum = new MathTaskClassLibrary.Class1.NumberSum();
            Assert.ThrowsException<ArgumentException>(() => numberSum.SumOfNumber("abc"));
            Assert.ThrowsException<ArgumentException>(() => numberSum.SumOfNumber(string.Empty));
        }
    }
}
