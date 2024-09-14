using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailCheckTest
{
    [TestClass]
    public class EmailCheckT
    {
        [TestMethod]
        public void EmailCheckValidDataTest()
        {
            var check = new MathTaskClassLibrary.Class1.EmailCheck();
            Assert.IsTrue(check.IsValidEmail("test@test.com"));
            Assert.IsTrue(check.IsValidEmail("sib@sib.ru"));
        }

        [TestMethod]
        public void EmailCheckInvalidDataTest()
        {
            var check = new MathTaskClassLibrary.Class1.EmailCheck();
            Assert.IsFalse(check.IsValidEmail("invalid-email"));
            Assert.IsFalse(check.IsValidEmail("test@.com"));
            Assert.IsFalse(check.IsValidEmail("@test.com"));
        }

        [TestMethod]
        public void EmailCheckEmptyDataTest()
        {
            var check = new MathTaskClassLibrary.Class1.EmailCheck();
            Assert.ThrowsException<ArgumentException>(() => check.IsValidEmail(""));
        }
    }
}
