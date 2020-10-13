using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mult_Odd_Index()
        {
            double[] array = { 1.2f, 3.2f, 4f };
            double result = Program.multOddIndex(array);

            double expected = 3.2f;

            Assert.AreEqual(expected, result);
        }
    }
}
