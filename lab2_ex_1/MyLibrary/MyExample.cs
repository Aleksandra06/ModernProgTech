using System;

namespace MyLibrary
{
    public static class MyExample
    {
        public static int MinThree(int a, int b, int c)
        {
            int min = a;
            if (b < min) 
                min = b;
            if (c < min)
                min = c;
            return min;
        }

        public static double SumChetIndexMassiv(double[,] a, int n, int m)
        {
            double sum = 0;
            for (int i = 0; i < m; i++) 
                for (int j = 0; j < n; j++) 
                    if ((i + j) % 2 == 0) 
                        sum += a[i,j]; 
            return sum;
        }

        public static double MaxElementDiagonal(double[,] a, int m)
        {
            double max = a[0,0];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                    if (j <= i && max < a[i,j])
                        max = a[i,j];
            return max;
        }
    }
}
