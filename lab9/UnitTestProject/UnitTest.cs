using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab9;
using TFrac;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFrac()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));
            Assert.AreEqual(tset1.ElementAt(1), new Frac(2, 3));
            Assert.AreEqual(tset1.ElementAt(0), new Frac(1, 2));
            Assert.AreEqual(tset1.ElementAt(2), new Frac(3, 4));
        }

        [TestMethod]
        public void TestClear()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));
            Assert.AreEqual(tset1.Show(), "1/2 2/3 3/4 ");

            tset1.Clear();
            Assert.AreEqual(tset1.Show(), "");
        }

        [TestMethod]
        public void TestRemove()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));
            tset1.Remove(new Frac(2, 3));
            Assert.AreEqual(tset1.Show(), "1/2 3/4 ");
        }

        [TestMethod]
        public void TestIsClear()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));

            Assert.AreEqual(tset1.IsClear(), false);
        }

        [TestMethod]
        public void TestIsClear2()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));
            tset1.Clear();

            Assert.AreEqual(tset1.IsClear(), true);
        }

        [TestMethod]
        public void TestContains()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));

            Assert.AreEqual(tset1.Contains(new Frac(2, 3)), true);
        }

        [TestMethod]
        public void TestContains2()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));

            Assert.AreEqual(tset1.Contains(new Frac(2, 30)), false);
        }

        [TestMethod]
        public void TestUnion()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));

            TSet<Frac> tset2 = new TSet<Frac>();
            tset2.Add(new Frac(1, 2));
            tset2.Add(new Frac(2, 3));
            tset2.Add(new Frac(5, 5));


            Assert.AreEqual(tset1.Union(tset2).Show(), "1/2 2/3 3/4 5/5 ");
        }

        [TestMethod]
        public void TestExcept()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));

            TSet<Frac> tset2 = new TSet<Frac>();
            tset2.Add(new Frac(1, 2));
            tset2.Add(new Frac(2, 3));
            tset2.Add(new Frac(5, 5));


            Assert.AreEqual(tset1.Except(tset2).Show(), "3/4 ");
        }

        [TestMethod]
        public void TestIntersect()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));

            TSet<Frac> tset2 = new TSet<Frac>();
            tset2.Add(new Frac(1, 2));
            tset2.Add(new Frac(2, 3));
            tset2.Add(new Frac(5, 5));


            Assert.AreEqual(tset1.Intersect(tset2).Show(), "1/2 2/3 ");
        }

        [TestMethod]
        public void TestCount()
        {
            TSet<Frac> tset1 = new TSet<Frac>();
            tset1.Add(new Frac(1, 2));
            tset1.Add(new Frac(2, 3));
            tset1.Add(new Frac(3, 4));

            Assert.AreEqual(tset1.Count(), 3);
        }
    }
}
