using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvaloniaApplication1.Models;

namespace RomanNumbersUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            var number = new RomanNumber(15);
            Assert.AreEqual("XV", number.ToString());
        }

        [TestMethod]
        public void TestClone()
        {
            var number = new RomanNumber(15);
            RomanNumber number2 = (RomanNumber) number.Clone();
            Assert.IsTrue(number.CompareTo(number2) == 0);
        }

        [TestMethod]
        public void TestAddOne()
        {
            var n1 = new RomanNumber(15);
            var n2 = new RomanNumber(43);
            var expected = new RomanNumber(15 + 43);
            var res = n1 + n2;
            Assert.IsTrue(res.CompareTo(expected) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestAddTwo()
        {
            var n1 = new RomanNumber(15);
            RomanNumber? n2 = null;
            var res = n1 + n2;
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestSubOne()
        {
            var n1 = new RomanNumber(15);
            var n2 = new RomanNumber(43);
            var res = n1 - n2;
        }

        [TestMethod]
        public void TestSubTwo()
        {
            var n1 = new RomanNumber(43);
            var n2 = new RomanNumber(15);
            Assert.IsTrue(
                (n1 - n2).CompareTo(new RomanNumber(43 - 15)) == 0
            );
        }

        [TestMethod]
        public void TestMulOne()
        {
            var n1 = new RomanNumber(2);
            var n2 = new RomanNumber(15);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(2 * 15)) == 0
            );
        }

        [TestMethod]
        public void TestMulTwo()
        {
            var n1 = new RomanNumber(232);
            var n2 = new RomanNumber(15);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(232 * 15)) == 0
            );
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestDivOne()
        {
            var n1 = new RomanNumber(232);
            var n2 = new RomanNumber(15);
            var res = n1 / n2;
        }

        [TestMethod]
        public void TestDivTwo()
        {
            var n1 = new RomanNumber(100);
            var n2 = new RomanNumber(10);
            Assert.IsTrue((n1 / n2).CompareTo(new RomanNumber(100 / 10)) == 0);
        }

        [TestMethod]
        public void TestCompareOne()
        {
            var n1 = new RomanNumber(100);
            var n2 = new RomanNumber(100);
            Assert.IsTrue(n1.CompareTo(n2) == 0);
        }

        [TestMethod]
        public void TestCompareTwo()
        {
            var n1 = new RomanNumber(99);
            var n2 = new RomanNumber(100);
            Assert.IsTrue(n1.CompareTo(n2) == -1);
        }

        [TestMethod]
        public void TestCompareThird()
        {
            var n1 = new RomanNumber(101);
            var n2 = new RomanNumber(100);
            Assert.IsTrue(n1.CompareTo(n2) == 1);
        }
    
        [TestMethod]
        public void TestRomanNumberExtendConstruct()
        {
            var n1 = new RomanNumberExtend("I");
            var n2 = new RomanNumberExtend(1);
            Assert.IsTrue(n1.CompareTo(n2) == 0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestRomanNumberExtendConstruct2()
        {
            var n1 = new RomanNumberExtend("IIIIV");
            Console.WriteLine(n1);

        }
    }
}