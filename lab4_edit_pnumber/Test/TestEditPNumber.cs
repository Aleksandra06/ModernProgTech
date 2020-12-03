using Microsoft.VisualStudio.TestTools.UnitTesting;
using UEditor;

namespace Test
{
    [TestClass]
    public class TestEditPNumber
    {
        [TestMethod]
        public void ConstructurZeroGood()
        {
            TEditor edit = new TEditor();
            string expected = "0,0";
            string result = edit.GetNumber();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ConstructurBCGood()
        {
            TEditor edit = new TEditor(16, 0);
            string expected = "0,0";
            string result = edit.GetNumber();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ConstructurNumberBCGood()
        {
            TEditor edit = new TEditor("16,16", 16, 2);
            string expected = "16,16";
            string result = edit.GetNumber();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void IsZeroGood()
        {
            TEditor edit = new TEditor();
            bool expected = true;
            bool result = edit.IsZero();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddSignoGood()
        {
            TEditor edit = new TEditor("16,16", 16, 2);
            string expected = "-16,16";
            string result = edit.AddSign();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddGood()
        {
            TEditor edit = new TEditor("16,0", 16, 1);
            string expected = "163,0";
            string result = edit.Add(3);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddZeroGood()
        {
            TEditor edit = new TEditor("16,0", 16, 1);
            string expected = "160,0";
            string result = edit.AddZero();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BackSpaceGood()
        {
            TEditor edit = new TEditor("16,3", 16, 1);
            string expected = "16,0";
            string result = edit.BackSpace();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ClearGood()
        {
            TEditor edit = new TEditor("16,3", 16, 1);
            string expected = "0,0";
            string result = edit.Clear();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetNumberGood()
        {
            TEditor edit = new TEditor("16,3", 16, 1);
            string expected = "16,3";
            string result = edit.GetNumber();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SetNumberGood()
        {
            TEditor edit = new TEditor("16,3", 16, 1);
            string expected = "124,5324";
            edit.SetNumber("124,5324");
            string result = edit.GetNumber();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ConstructurBCFail()
        {
            TEditor edit = new TEditor(17, 1);
            string expected = "0,0";
            string result = edit.GetNumber();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ConstructurNumberBCFail()
        {
            TEditor edit = new TEditor("16,3", 1, 1);
            string expected = "0,0";
            string result = edit.GetNumber();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void IsZeroFail()
        {
            TEditor edit = new TEditor("16,3", 16, 1);
            bool expected = false;
            bool result = edit.IsZero();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddSignoFail()
        {
            TEditor edit = new TEditor("-16,3", 16, 1);
            string expected = "16,3";
            string result = edit.AddSign();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddFail()
        {
            TEditor edit = new TEditor("-16,3", 16, 1);
            string expected = "-16,3";
            string result = edit.Add(4);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddZeroFail()
        {
            TEditor edit = new TEditor("-16,3", 16, 1);
            string expected = "-16,3";
            string result = edit.AddZero();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BackSpaceFail()
        {
            TEditor edit = new TEditor("-16,3345", 16, 4);
            string expected = "-16,334";
            string result = edit.BackSpace();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ClearFail()
        {
            TEditor edit = new TEditor("0,0", 16, 1);
            string expected = "0,0";
            string result = edit.BackSpace();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SetNumberFail()
        {
            TEditor edit = new TEditor("110,0", 10, 1);
            string expected = "110,0";
            string result = edit.SetNumber("1A,2B");
            Assert.AreEqual(expected, result);
        }
    }
}
