using Microsoft.VisualStudio.TestTools.UnitTesting;
using Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CountSignChangesTest()
        {

            int[] sequence = { 1, 2, 3, 4, 5 };
            int expected = 0;

            int result = Logic.CountSignChanges(sequence);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CountSignChangesTest1()
        {
            int[] sequence = { 1, -1, 2, -2, 3, -3 };
            int expected = 5; 

            int result = Logic.CountSignChanges(sequence);

            Assert.AreEqual(expected, result);
        }
    }
}