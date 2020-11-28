using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab6;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Init_And_Output_1()
        {
            TEditor testClass = new TEditor();
            string output = "10,3+i*0,8";
            testClass.WriteNumber(output);
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void Init_And_Output_2()
        {
            TEditor testClass = new TEditor();
            string output = "-12,6-i*66,2";
            testClass.WriteNumber(output);
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void Init_And_Output_3()
        {
            TEditor testClass = new TEditor();
            string output = "0,3+i*0,0";
            testClass.WriteNumber(output);
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void IsZero_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("12,36+i*12,35");
            Assert.IsFalse(testClass.IsZero());
        }
        [TestMethod]
        public void IsZero_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("0,+i*0,");
            Assert.IsTrue(testClass.IsZero());
        }
        [TestMethod]
        public void ToggleMinus_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("12,36+i*12,35");
            testClass.ToggleMinus();
            string output = "-12,36+i*12,35";
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void ToggleMinus_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("-12,36+i*12,35");
            testClass.ToggleMinus();
            string output = "12,36+i*12,35";
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void AddNumber_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("0,36+i*1,4");
            testClass.AddNumber(4);
            string output = "4,36+i*1,4";
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void AddNumber_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("-25,6-i*44,44");
            testClass.AddNumber(0);
            string output = "-250,6-i*44,44";
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void DelNumber_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("0,4+i*44,44");
            testClass.DelNumber();
            string output = "0,4+i*44,44";
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void DelNumber_2()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("55,55-i*3,3");
            testClass.ToggleMode();
            testClass.DelNumber();
            string output = "55,55-i*0,3";
            Assert.AreEqual(output, testClass.ReadNumber());
        }
        [TestMethod]
        public void Clear_1()
        {
            TEditor testClass = new TEditor();
            testClass.WriteNumber("55,55-i*3,3");
            testClass.Clear();
            string output = "0,+i*0,";
            Assert.AreEqual(output, testClass.ReadNumber());
        }
    }
}
