using MyLibrary;
using Xunit;

namespace UnitTest
{
    public class UnitTestMaxElementDiagonal
    {
        [Fact]
        public void Nulleble()
        {
            double[,] mas = new double[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            int n = 3;
            int m = 4;
            var result = MyExample.SumChetIndexMassiv(mas, n, m);
            var otvet = 0;
            Assert.Equal(result, otvet);
        }
        [Fact]
        public void Plus()
        {
            double[,] mas = new double[,] { { 1, 2, 3 }, { 4, 5, 10 }, { 28, 99, 0 } };
            int n = 3;
            var result = MyExample.MaxElementDiagonal(mas, n);
            var otvet = 99;
            Assert.Equal(result, otvet);
        }
        [Fact]
        public void Minus()
        {
            double[,] mas = new double[,] { { -55, -66, -24 }, { -4, -5, -10 }, { -28, -99, 0 } };
            int n = 3;
            var result = MyExample.MaxElementDiagonal(mas, n);
            var otvet = 0;
            Assert.Equal(result, otvet);
        }
        [Fact]
        public void One()
        {
            double[,] mas = new double[,] { { 88, -66, -24 }, { -4, -5, -10 }, { -28, -99, 0 } };
            int n = 3;
            var result = MyExample.MaxElementDiagonal(mas, n);
            var otvet = 88;
            Assert.Equal(result, otvet);
        }
    }
}
