using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculations.Tests
{
    [TestClass()]
    public class ComputationalTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            Computational.Addition(8, 2, 4);
            Assert.AreEqual(Computational.Answer, 10);
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            Computational.Subtraction(16, 2, 4);
            Assert.AreEqual(Computational.Answer, 14);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Computational.Multiplication(5, 3, 4);
            Assert.AreEqual(Computational.Answer, 15);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            Computational.Division(10, 2, 4);
            Assert.AreEqual(Computational.Answer, 5);
        }

        [TestMethod()]
        public void RemainderTest()
        {
            Computational.Remainder(12, 5, 4);
            Assert.AreEqual(Computational.Answer, 2);
        }
    }
}