using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuadraticEquationTest
{
    [TestClass]
    public class QuadraticEquationT
    {
        [TestMethod]
        public void EquationValidDataTest()
        {
            var equation = new MathTaskClassLibrary.Class1.QuadraticEquation();
            var roots1 = equation.Solve(1, 2, -3);
            Assert.AreEqual(2, roots1.Length);
            Assert.AreEqual(1, roots1[0], 0.01);
            Assert.AreEqual(-3, roots1[1], 0.01);
         
            var roots2 = equation.Solve(1, -4, 4);
            Assert.AreEqual(1, roots2.Length);
            Assert.AreEqual(2, roots2[0], 0.01);
        
            var roots3 = equation.Solve(1, 0, 1);
            Assert.AreEqual(0, roots3.Length);
        }

        [TestMethod]
        public void EquationInvalidDataTest()
        {
            var equation = new MathTaskClassLibrary.Class1.QuadraticEquation();
            Assert.ThrowsException<ArgumentException>(() => equation.Solve(0, 2, 3));
        }
    }
}

