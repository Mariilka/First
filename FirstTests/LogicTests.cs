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
            int number = 321;
            int expected = 3;

            int result = Logic.FindMaxDigit(number);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void IsThreeDigitNumberTest()
        {

            int number = 100;

            bool result = Logic.IsThreeDigitNumber(number);

            Assert.IsTrue(result);
        }

       
    }
}