using System;
using MyLibrary;
using Xunit;

namespace UnitTest
{
    public class UnitTestMinThree
    {
        [Fact]
        public void MinThreeAMinPlus()
        {
            int a = 0;
            int b = 1;
            int c = 10;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(a, min);
        }
        [Fact]
        public void MinThreeAMinMinus()
        {
            int a = -1000;
            int b = -500;
            int c = 10;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(a, min);
        }

        [Fact]
        public void MinThreeBMinPlus()
        {
            int a = 92837;
            int b = 748;
            int c = 91382343;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(b, min);
        }
        [Fact]
        public void MinThreeBMinMinus()
        {
            int a = -1000;
            int b = -50100;
            int c = -7298;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(b, min);
        }
        [Fact]
        public void MinThreeCMinPlus()
        {
            int a = 92837;
            int b = 748;
            int c = 88;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(c, min);
        }
        [Fact]
        public void MinThreeCMinMinus()
        {
            int a = -1000;
            int b = -50100;
            int c = -298338;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(c, min);
        }
        [Fact]
        public void MinThreeRavnPlus()
        {
            int a = 98338;
            int b = 98338;
            int c = 98338;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(a, min);
        }
        [Fact]
        public void MinThreeRavnMinus()
        {
            int a = -298338;
            int b = -298338;
            int c = -298338;

            int min = MyExample.MinThree(a, b, c);

            Assert.Equal(c, min);
        }
    }
}
