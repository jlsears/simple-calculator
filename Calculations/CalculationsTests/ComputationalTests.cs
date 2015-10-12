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
    }
}