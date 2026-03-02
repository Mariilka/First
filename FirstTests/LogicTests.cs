using Microsoft.VisualStudio.TestTools.UnitTesting;
using First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void FindMaxDigitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsThreeDigitNumberTest()
        {
            int number = 100;

            bool result = Logic.IsThreeDigitNumber(number);

            Assert.True(result);
        }
    }
}