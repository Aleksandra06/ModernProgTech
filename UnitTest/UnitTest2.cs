using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Shift_Right()
        {
            double[] result = { 1.2f, 3.2f, 4f };
            int k = 2;
            double[] expected = { 3.2f, 4f, 1.2f };

            Program.shiftRight(result, k);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
