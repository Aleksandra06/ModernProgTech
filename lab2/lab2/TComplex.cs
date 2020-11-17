using System;

namespace lab2
{
    public class TComplex
    {
        public double real { get; set; }
        public double imaginary { get; set; }

        public TComplex(double a, double b)
        {
            real = a;
            imaginary = b;
        }

        public TComplex(string str)
        {
            try
            {
                str = str.Replace(" ", "");
                var indexPlus = str.IndexOf("+");
                var astr = str.Substring(0, indexPlus);
                var bstr = str.Substring(indexPlus + 3, str.Length - indexPlus - 3);
                real = Double.Parse(astr);
                imaginary = Double.Parse(bstr);
            }
            catch
            {
                throw new ExComplex("Не получилось обработать строку");
            }
        }

        public TComplex Copy()
        {
            return (TComplex) this.MemberwiseClone();
        }

        public TComplex Add(TComplex add)
        {
            return new TComplex(this.real + add.real, this.imaginary + add.imaginary);
        }

        public TComplex Mulri(TComplex b)
        {
            return new TComplex(this.real * b.real - this.imaginary * b.imaginary,
                this.real * b.imaginary + this.imaginary * b.real);
        }

        public TComplex Square()
        {
            return new TComplex(this.real * this.real - this.imaginary * this.imaginary,
                this.real * this.imaginary + this.real * this.imaginary);
        }

        public TComplex Reverse()
        {
            return new TComplex(this.real / (this.real * this.real + this.imaginary * this.imaginary),
                -this.imaginary / (this.real * this.real + this.imaginary * this.imaginary));
        }

        public TComplex Subtract(TComplex b)
        {
            return new TComplex(this.real - b.real, this.imaginary - b.imaginary);
        }

        public TComplex Divide(TComplex anClass)
        {
            return new TComplex((this.real * anClass.real + this.imaginary * anClass.imaginary) / (anClass.real * anClass.real + anClass.imaginary * anClass.imaginary),
                (anClass.real * this.imaginary - this.real * anClass.imaginary) / (anClass.real * anClass.real + anClass.imaginary * anClass.imaginary));
        }

        public TComplex Minus()
        {
            return new TComplex(this.real != 0 ? -this.real : 0, this.imaginary != 0 ? -this.imaginary : 0);
        }

        public double Abs()
        {
            return Math.Sqrt(this.real * this.real + this.imaginary * this.imaginary);
        }

        public double Rad()
        {
            if (real > 0)

                return Math.Atan(imaginary / real);

            if (real == 0 && imaginary > 0)

                return (Math.PI / 2);

            if (real < 0)

                return (Math.Atan(imaginary / real) + Math.PI);

            if (real == 0 && imaginary < 0)

                return (-Math.PI / 2);

            return 0;
        }

        public double Degree()
        {
            return Rad() * 180 / Math.PI;
        }

        public TComplex Pow(int n)
        {
            return new TComplex(Math.Pow(Abs(), n) * Math.Cos(n * Rad()), Math.Pow(Abs(), n) * Math.Sin(n * Rad()));
        }

        public TComplex Sqrt(int powN, int rootI)
        {
            if (powN == 0)

                return new TComplex(1, 0);

            if (rootI == 0)
                new ExComplex("Деление на 0. ");

            TComplex new1 = Pow(powN);

            return new TComplex(Math.Pow(new1.Abs(), 1 / (double)rootI) * Math.Cos((new1.Rad() + 2 * Math.PI * rootI) / rootI), Math.Pow(new1.Abs(), 1 / (double)rootI) * Math.Sin((new1.Rad() + 2 * Math.PI * rootI) / rootI));
        }

        public bool Ravn(TComplex anClass)
        {
            return (this.real == anClass.real && this.imaginary == anClass.imaginary);
        }

        public bool NeRavn(TComplex anClass)
        {
            return (this.real != anClass.real || this.imaginary != anClass.imaginary);
        }

        public double GetRealNumber()
        {
            return this.real;
        }

        public double GetImaginaryNumber()
        {
            return this.imaginary;
        }

        public string GetRealString()
        {
            return this.real.ToString();
        }

        public string GetImaginaryString()
        {
            return this.imaginary.ToString();
        }

        public string GetString()
        {
            return this.real.ToString("##,###") + ' ' + (this.imaginary >= 0 ? '+' : '-') + " i * " + this.imaginary.ToString("##,###");
        }
    }
}
