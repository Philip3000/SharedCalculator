using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator.Tests
{
    [TestClass()]
    public class BasicMathTests
    {
        //If test passes then Addition method should be working
        [TestMethod()]
        public void AdditionTest()
        {
            double testingAdditionTrue = 10.15;
            double v = BasicMath.Addition(3.15, 7);
            Assert.AreEqual(testingAdditionTrue, v);
        }
        //If test passes then Subtraction method should be working
        [TestMethod()]
        public void SubtractionTest()
        {
            double testingSubtractionTrue = 4.2;
            double v = BasicMath.Subtraction(37, 32.8);
            Assert.AreEqual(testingSubtractionTrue, v,0.0005);
        }
        //If test passes then Multiplication method should be working
        [TestMethod()]
        public void MultiplicationTest()
        {
            double testingMultiplicationTrue = 44;
            double v = BasicMath.Multiplication(10, 4.4);
            Assert.AreEqual(testingMultiplicationTrue, v);
        }
        //If test passes then disvion method should be working
        [TestMethod()]
        public void DivisionTest()
        {
            double testingDivisionTrue = 15;
            double v = BasicMath.Division(240, 16);
            Assert.AreEqual(testingDivisionTrue, v);
        }
    }
}