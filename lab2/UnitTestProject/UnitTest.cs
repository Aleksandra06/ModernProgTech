using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab2;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestTComplexDouble()
        {
            var testClass = new TComplex(55.89, 44.44);

            Assert.AreEqual(testClass.real, 55.89);
            Assert.AreEqual(testClass.imaginary, 44.44);
        }
        [TestMethod]
        public void TestTComplexString()
        {
            string output = "7,5 + i * 3,1";
            var testClass = new TComplex(output);

            Assert.AreEqual(testClass.real, 7.5);
            Assert.AreEqual(testClass.imaginary, 3.1);
        }
        [TestMethod]
        public void TestTComplexStringEx()
        {
            Action action = new Action(Action1);

            Assert.ThrowsException<ExComplex>(action);
        }
        private void Action1()
        {
            string output = "7,5te +t i * 3,1";
            new TComplex(output);
        }

        [TestMethod]
        public void TestCopy()
        {
            var test1 = new TComplex(55.89, 44.44);
            var test2 = test1.Copy();

            Assert.AreEqual(test1.real, test2.real);
            Assert.AreEqual(test1.imaginary, test2.imaginary);
        }

        [TestMethod]
        public void TestAdd()
        {
            var test1 = new TComplex(3, 4);
            var test2 = new TComplex(4, -1);
            var resulr = test1.Add(test2);

            Assert.AreEqual(resulr.real, 7);
            Assert.AreEqual(resulr.imaginary, 3);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var test1 = new TComplex(3, 4);
            var test2 = new TComplex(4, -1);
            var resulr = test1.Mulri(test2);

            Assert.AreEqual(resulr.real, 16);
            Assert.AreEqual(resulr.imaginary, 13);
        }

        [TestMethod]
        public void TestSubstract()
        {
            var test1 = new TComplex(3, 4);
            var test2 = new TComplex(4, -1);
            var resulr = test1.Subtract(test2);

            Assert.AreEqual(resulr.real, -1);
            Assert.AreEqual(resulr.imaginary, 5);
        }

        [TestMethod]
        public void TestDivide()
        {
            var test1 = new TComplex(3, 4);
            var test2 = new TComplex(4, -1);
            var resulr = test1.Divide(test2);

            Assert.AreEqual(resulr.real, 0.470588,5);
            Assert.AreEqual(resulr.imaginary, 1.117647,5);
        }

        [TestMethod]
        public void TestSquare()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.Square();

            Assert.AreEqual(resulr.real, -7);
            Assert.AreEqual(resulr.imaginary, 24);
        }

        [TestMethod]
        public void TestReverse()
        {
            var test1 = new TComplex(0, -3);
            var resulr = test1.Reverse();

            Assert.AreEqual(resulr.real, 0);
            Assert.AreEqual(resulr.imaginary, 0.333333, 5);
        }

        [TestMethod]
        public void TestMinus()
        {
            var test1 = new TComplex(0, 4);
            var resulr = test1.Minus();

            Assert.AreEqual(resulr.real, 0);
            Assert.AreEqual(resulr.imaginary, -4);
        }

        [TestMethod]
        public void TestAbs()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.Abs();

            Assert.AreEqual(resulr, 5);
        }

        [TestMethod]
        public void TestRad()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.Rad();

            Assert.AreEqual(0.927295, resulr, 5);
        }

        [TestMethod]
        public void TestDegree()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.Degree();

            Assert.AreEqual(53.1301, resulr, 4);
        }

        [TestMethod]
        public void TestPow()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.Pow(5);

            Assert.AreEqual(resulr.real, -237, 4);
            Assert.AreEqual(resulr.imaginary, -3116, 4);
        }

        [TestMethod]
        public void TestRoot()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.Sqrt(3,4);

            Assert.AreEqual(resulr.real, 2.567133, 5);
            Assert.AreEqual(resulr.imaginary, 2.142468, 5);
        }

        [TestMethod]
        public void TestRavnFalse()
        {
            var test1 = new TComplex(3, 4);
            var test2 = new TComplex(4, -1);
            var resulr = test1.Ravn(test2);

            Assert.IsFalse(resulr);
        }
        [TestMethod]
        public void TestRavnTrue()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.Ravn(test1);

            Assert.IsTrue(resulr);
        }

        [TestMethod]
        public void TestNeRavnFalse()
        {
            var test1 = new TComplex(3, 4);
            var test2 = new TComplex(4, -1);
            var resulr = test1.NeRavn(test2);

            Assert.IsTrue(resulr);
        }
        [TestMethod]
        public void TestNeRavnTrue()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.NeRavn(test1);

            Assert.IsFalse(resulr);
        }

        [TestMethod]
        public void TestGetRealNumber()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.GetRealNumber();

            Assert.AreEqual(resulr, 3);
        }

        [TestMethod]
        public void TestGetImaginaryNumber()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.GetImaginaryNumber();

            Assert.AreEqual(resulr, 4);
        }

        [TestMethod]
        public void TestGetRealString()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.GetRealString();

            Assert.AreEqual(resulr, "3");
        }

        [TestMethod]
        public void TestGetImaginaryString()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.GetImaginaryString();

            Assert.AreEqual(resulr, "4");
        }

        [TestMethod]
        public void TestGetString()
        {
            var test1 = new TComplex(3, 4);
            var resulr = test1.GetString();

            Assert.AreEqual(resulr, "3 + i * 4");
        }
    }
}
