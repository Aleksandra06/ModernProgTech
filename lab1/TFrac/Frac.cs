using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFrac
{
    public class Frac : TFrac
    {
        public Frac(int a, int b) : base(a, b)
        {

        }

        public Frac(string str) : base(str)
        {

        }

        public Frac() : base()
        {

        }

        public static Frac operator +(Frac t1, Frac t2)
        {
            return (Frac)t1.Add(t2);
        }

        public static Frac operator *(Frac t1, Frac t2)
        {
            return (Frac)t1.Multiplication(t2);
        }

        public static Frac operator -(Frac t1, Frac t2)
        {
            return (Frac)t1.Difference(t2);
        }

        public static Frac operator /(Frac t1, Frac t2)
        {
            return (Frac)t1.Division(t2);
        }

        public static Frac operator /(int t1, Frac t2)
        {
            return (Frac)(new Frac(1,1)).Division(t2);
        }
    }
}
