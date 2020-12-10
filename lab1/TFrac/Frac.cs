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

        public override string ToString()
        {
            return GetString();
        }

        public override int GetHashCode()
        {
            return this.Numerator.GetHashCode() + this.Denominator.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Frac frac = (Frac)obj;
            if ((frac.Numerator == this.Numerator) && (this.Denominator == frac.Denominator))
            {
                return true;
            }
            else return false;
        }
        public static bool operator ==(Frac t1, Frac t2)
        {
            return (t1.Numerator == t2.Numerator) && (t1.Denominator == t2.Denominator);
        }
        public static bool operator !=(Frac t1, Frac t2)
        {
            return (t1.Numerator != t2.Numerator) || (t1.Denominator != t2.Denominator);
        }

        public static bool operator >(Frac t1, Frac t2)
        {
            return ((double)t1.Numerator / (double)t1.Denominator) > ((double)t2.Numerator / (double)t2.Denominator);
        }
        public static bool operator <(Frac t1, Frac t2)
        {
            return ((double)t1.Numerator / (double)t1.Denominator) < ((double)t2.Numerator / (double)t2.Denominator);
        }
    }
}
