using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace FizzBuzz
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class UnitTest1
    {
        [TestMethod]
        public void IfLineNumberIsOnePrintOne()
        {
            FizzBuzzPrinter fb = new FizzBuzzPrinter();
            Assert.AreEqual(1.ToString(), fb.PrintLine(1));
        }

        [TestMethod]
        public void IfLineNumberIsDivisibleByThreePrintFizz()
        {
            FizzBuzzPrinter fb = new FizzBuzzPrinter();
            Assert.AreEqual("Fizz", fb.PrintLine(3));
        }

        [TestMethod]
        public void IfLineNumberIsDivisibleByFivePrintBuzz()
        {
            FizzBuzzPrinter fb = new FizzBuzzPrinter();
            Assert.AreEqual("Buzz", fb.PrintLine(5));
        }

        [TestMethod]
        public void IfLineNumberIsDivisibleByThreeAndFivePrintFizzBuzz()
        {
            FizzBuzzPrinter fb = new FizzBuzzPrinter();
            Assert.AreEqual("FizzBuzz", fb.PrintLine(15));
        }

        [TestMethod]
        public void PrintLinesOneToOneHundred()
        {
            FizzBuzzPrinter fb = new FizzBuzzPrinter();            
            Approvals.Verify(fb.PrintLines(1, 100));
        }

    }
}
