using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFrac;

namespace UnitTestProject
{
    [TestClass]
    public class TFracUnitTest
    {
        [TestMethod]
        public void TestTFracInt()
        {
            var tfr = new TFrac.Frac(845, 4895);

            Assert.AreEqual(tfr.Numerator, 845);
            Assert.AreEqual(tfr.Denominator, 4895);
        }
        [TestMethod]
        public void TestTFracInt2()
        {
            Action action = new Action(Action1);

            Assert.ThrowsException<ExFrac>(action);
        }
        private void Action1()
        {
            new Frac(113, 0);
        }
        [TestMethod]
        public void TestTFracStr1()
        {
            var tfr = new TFrac.Frac("77/88");

            Assert.AreEqual(tfr.Numerator, 77);
            Assert.AreEqual(tfr.Denominator, 88);
        }
        [TestMethod]
        public void TestTFracStr2()
        {
            Action action = new Action(Action2);

            Assert.ThrowsException<ExFrac>(action);
        }
        private void Action2()
        {
            new Frac("23/0");
        }

        [TestMethod]
        public void TestCopy()
        {
            var f1 = new Frac(11,12);
            var fCopy = f1.Copy();

            Assert.AreEqual(f1.Numerator, fCopy.Numerator);
            Assert.AreEqual(f1.Denominator, fCopy.Denominator);
        }

        [TestMethod]
        public void TestAdd()
        {
            var f1 = new Frac(3, 2);
            var f2 = new Frac(1, 3);
            var otv = f1.Add(f2);

            Assert.AreEqual(otv.Numerator, 11);
            Assert.AreEqual(otv.Denominator, 6);
        }
        [TestMethod]
        public void TestDifference()
        {
            var f1 = new Frac(1, 2);
            var f2 = new Frac(1, 3);
            var otv = f1.Difference(f2);

            Assert.AreEqual(otv.Numerator, 1);
            Assert.AreEqual(otv.Denominator, 6);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            var f1 = new Frac(11, 2);
            var f2 = new Frac(13, 7);
            var otv = f1.Multiplication(f2);

            Assert.AreEqual(otv.Numerator, 143);
            Assert.AreEqual(otv.Denominator, 14);
        }
        [TestMethod]
        public void TestDivision()
        {
            var f1 = new Frac(1, 2);
            var f2 = new Frac(13, 7);
            var otv = f1.Division(f2);

            Assert.AreEqual(otv.Numerator, 7);
            Assert.AreEqual(otv.Denominator, 26);
        }
        [TestMethod]
        public void TestSquare()
        {
            var f1 = new Frac(3, 2);
            var otv = f1.Square();

            Assert.AreEqual(otv.Numerator, 9);
            Assert.AreEqual(otv.Denominator, 4);
        }
        [TestMethod]
        public void TestReverse()
        {
            var f1 = new Frac(3, 2);
            var otv = f1.Reverse();

            Assert.AreEqual(otv.Numerator, 2);
            Assert.AreEqual(otv.Denominator, 3);
        }
        [TestMethod]
        public void TestMinus()
        {
            var f1 = new Frac(3, 2);
            var otv = f1.Minus();

            Assert.AreEqual(otv.Numerator, -3);
            Assert.AreEqual(otv.Denominator, 2);
        }
        [TestMethod]
        public void TestRavn()
        {
            var f1 = new Frac(1, 2);
            var f2 = new Frac(1, 2);
            var otv = f1.Ravn(f2);

            Assert.IsTrue(otv);
        }
        [TestMethod]
        public void TestMore()
        {
            var f1 = new Frac(2, 3);
            var f2 = new Frac(1, 2);
            var otv = f1.More(f2);

            Assert.IsTrue(otv);
        }
        [TestMethod]
        public void TestGetNumeratorNumber()
        {
            var f1 = new Frac(2, 3);
            var otv = f1.GetNumeratorNumber();

            Assert.AreEqual(otv, 2);
        }
        [TestMethod]
        public void TestGetDenominatorNumber()
        {
            var f1 = new Frac(2, 3);
            var otv = f1.GetDenominatorNumber();

            Assert.AreEqual(otv, 3);
        }
        [TestMethod]
        public void TestGetNumeratorString()
        {
            var f1 = new Frac(2, 3);
            var otv = f1.GetNumeratorString();

            Assert.AreEqual(otv, "2");
        }
        [TestMethod]
        public void TestGetDenominatorString()
        {
            var f1 = new Frac(2, 3);
            var otv = f1.GetDenominatorString();

            Assert.AreEqual(otv, "3");
        }
        [TestMethod]
        public void TestGetString()
        {
            var f1 = new Frac(2, 3);
            var otv = f1.GetString();

            Assert.AreEqual(otv, "2/3");
        }
    }
}
