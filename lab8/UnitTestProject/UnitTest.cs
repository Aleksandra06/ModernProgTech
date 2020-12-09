using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab8;
using TFrac;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestOperationsFrac()
        {
            Processor<Frac> processor = new Processor<Frac>(new Frac(1, 3), new Frac(1, 3));
            processor.OperationSet(1);
            processor.OperationRun();
            var otvet = new Frac(2, 3);
            Assert.AreEqual(otvet.Denominator, processor.Lop_Res.Denominator);
            Assert.AreEqual(otvet.Numerator, processor.Lop_Res.Numerator);
            processor.OperationSet(2);
            processor.OperationRun(); 
            otvet = new Frac(1, 3);
            Assert.AreEqual(otvet.Denominator, processor.Lop_Res.Denominator);
            Assert.AreEqual(otvet.Numerator, processor.Lop_Res.Numerator);
            processor.OperationSet(3);
            processor.OperationRun();
            otvet = new Frac(1, 9);
            Assert.AreEqual(otvet.Denominator, processor.Lop_Res.Denominator);
            Assert.AreEqual(otvet.Numerator, processor.Lop_Res.Numerator);
            processor.OperationSet(4);
            processor.OperationRun(); 
            otvet = new Frac(1, 3);
            Assert.AreEqual(otvet.Denominator, processor.Lop_Res.Denominator);
            Assert.AreEqual(otvet.Numerator, processor.Lop_Res.Numerator);
        }

        [TestMethod]
        public void TestFunctionsFrac()
        {
            Processor<Frac> processor = new Processor<Frac>(new Frac(1, 3), new Frac(1, 3));
            processor.FunctionSet(1);
            processor.FunctionRun();
            var otvet = new Frac(3,  1);
            Assert.AreEqual(otvet.Denominator, processor.Rop.Denominator);
            Assert.AreEqual(otvet.Numerator, processor.Rop.Numerator);
            processor.FunctionSet(2);
            processor.FunctionRun();
            otvet = new Frac(9, 1);
            Assert.AreEqual(otvet.Denominator, processor.Rop.Denominator);
            Assert.AreEqual(otvet.Numerator, processor.Rop.Numerator);
        }

        [TestMethod]
        public void TestOperationsInt()
        {
            Processor<int> processor = new Processor<int>(2, 5);
            processor.OperationSet(1);
            processor.OperationRun();
            Assert.AreEqual(7, processor.Lop_Res);
            processor.OperationSet(2);
            processor.OperationRun();
            Assert.AreEqual(2, processor.Lop_Res);
            processor.OperationSet(3);
            processor.OperationRun();
            Assert.AreEqual(10, processor.Lop_Res);
            processor.OperationSet(4);
            processor.OperationRun();
            Assert.AreEqual(2, processor.Lop_Res);
        }

        [TestMethod]
        public void TestFunctionsInt()
        {
            Processor<int> processor = new Processor<int>(2, 1);
            processor.FunctionSet(1);
            processor.FunctionRun();
            Assert.AreEqual(1, processor.Rop);
            processor.FunctionSet(2);
            processor.FunctionRun();
            Assert.AreEqual(1, processor.Rop);
        }
    }
}
