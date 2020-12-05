using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab7;
using TFrac;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodAddSet()
        {
            var f = new TMemory<Frac>();
            f.WriteMemory(new Frac(1, 5));
            var otvet = new Frac(1, 5);
            Assert.AreEqual(otvet.Denominator, f.ReadNumber().Denominator);
            Assert.AreEqual(otvet.Numerator, f.ReadNumber().Numerator);
        }
        [TestMethod]
        public void TestMethodGetSt()
        {
            TMemory<Frac> f = new TMemory<Frac>();

            Assert.IsFalse(f.ReadState());

            f.WriteMemory(new Frac(1, 5));

            Assert.IsTrue(f.ReadState());
        }

        [TestMethod]
        public void TestMethodClear()
        {
            TMemory<Frac> f = new TMemory<Frac>();
            f.WriteMemory(new Frac(5, 6));
            var otvet = new Frac(5, 6);

            Assert.AreEqual(otvet.Denominator, f.ReadNumber().Denominator);
            Assert.AreEqual(otvet.Numerator, f.ReadNumber().Numerator);

            f.Clear();

            otvet = new Frac();
            Assert.AreEqual(otvet.Denominator, f.ReadNumber().Denominator);
            Assert.AreEqual(otvet.Numerator, f.ReadNumber().Numerator);
        }

        [TestMethod]
        public void TestMethodGet()
        {
            TMemory<Frac> f = new TMemory<Frac>();
            f.WriteMemory(new Frac(5, 6));
            var otvet = new Frac(5, 6);

            Assert.AreEqual(otvet.Denominator, f.Get().Denominator);
            Assert.AreEqual(otvet.Numerator, f.Get().Numerator);
        }
    }
}
