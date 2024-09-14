using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YearDays
{
    [TestClass]
    public class YearDaysTest
    {
        [TestMethod]
        public void YearDaysValidDataTest()
        {
            var yearDays = new MathTaskClassLibrary.Class1.YearDays1();
            Assert.AreEqual(365, yearDays.DaysInYear(2021));
            Assert.AreEqual(366, yearDays.DaysInYear(2020));
            Assert.AreEqual(365, yearDays.DaysInYear(1900));
            Assert.AreEqual(366, yearDays.DaysInYear(2000));
        }

        [TestMethod]
        public void YearDaysInvalidDataTest()
        {
            var yearDays = new MathTaskClassLibrary.Class1.YearDays1();
            Assert.ThrowsException<ArgumentException>(() => yearDays.DaysInYear(0));
            Assert.ThrowsException<ArgumentException>(() => yearDays.DaysInYear(-1));
        }
    }
}
