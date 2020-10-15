using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Convert()
        {
            string str = "14A";
            int b = 16;

            int expected = 330;
            int result = Program.convert(str ,b);

            Assert.AreEqual(expected, result);
        }
    }
}
