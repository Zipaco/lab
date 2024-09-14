using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class LettersTests
    {
        [TestMethod]
        public void GenerateLetters_ValidInput_ReturnsCorrectString()
        {
            var generator = new Class1.CheckingLetters();
            Assert.AreEqual("A", generator.GenerateLetters(1));
            Assert.AreEqual("ABCD", generator.GenerateLetters(4));
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", generator.GenerateLetters(26));
        }

        public void GenerateLetters_InvalidInput_ThrowsArgumentException()
        {
            var generator = new Class1.CheckingLetters();
            Assert.ThrowsException<ArgumentException>(() => generator.GenerateLetters(0));
            Assert.ThrowsException<ArgumentException>(() => generator.GenerateLetters(27));
        }

        //public void CalculateAreaInvalidDataTest1()
        //{
        //    int a = -4;
        //    int b = 10;
        //    Geometry g = new Geometry();
        //    Assert.ThrowsException<ArgumentException>(() => g.CalculateArea(a, b), "не обработаны отрицательные длины сторон пямоугольника");
        //}

        
    }
}


