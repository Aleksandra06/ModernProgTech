using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab5;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Init_And_Output_1()
        {
            TEditor testClass = new TEditor();
            string output = "3/4";
            testClass.WriteString(output);
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void Init_And_Output_2()
        {
            TEditor testClass = new TEditor();
            string output = "-16/3";
            testClass.WriteString(output);
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void IsZero_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("14/3");
            Assert.IsFalse(testClass.IsZero());
        }

        [TestMethod]
        public void IsZero_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("0/11");
            Assert.IsTrue(testClass.IsZero());
        }

        [TestMethod]
        public void ToggleMinus_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("3/4");
            testClass.ToggleMinus();
            string output = "-3/4";
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void ToggleMinus_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("-3/4");
            testClass.ToggleMinus();
            string output = "3/4";
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void AddNumber_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("-3/4");
            testClass.AddNumber(4);
            string output = "-43/4";
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void AddNumber_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("0/1");
            testClass.AddNumber(4);
            string output = "4/1";
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void DelNumber_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("42/3");
            testClass.DelSymbol();
            string output = "42/3";
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void DelNumber_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("42/34");
            testClass.DelSymbol();
            string output = "42/3";
            Assert.AreEqual(output, testClass.ReadString());
        }

        [TestMethod]
        public void Clear()
        {
            TEditor testClass = new TEditor();
            testClass.WriteString("42/34");
            testClass.Clear();
            string output = "0/1";
            Assert.AreEqual(output, testClass.ReadString());
        }
    }
}
