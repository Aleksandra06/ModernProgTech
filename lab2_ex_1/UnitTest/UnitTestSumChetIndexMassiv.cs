using System;
using MyLibrary;
using Xunit;

namespace UnitTest
{
    public class UnitTestSumChetIndexMassiv
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
        public void OneTwo()
        {
            double[,] mas = new double[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int n = 3;
            int m = 4;
            var result = MyExample.SumChetIndexMassiv(mas, n, m);
            var otvet = 12;
            Assert.Equal(result, otvet);
        }
    }
}
