using System;
using System.Collections.Generic;

namespace SimpleFraction
{
    public abstract class TFrac
    {
        private int numerator;
        private int denominator;

        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
            }
        }

        //public TFrac()
        //{
        //    Numerator = 0;
        //    Denominator = 1;
        //}

        public TFrac(int a, int b)
        {
            Numerator = a;
            if (b == 0)
            {
                throw new ExFrac("Деление на ноль невозможно!");
            }
            Denominator = b;
        }

        public TFrac(string str)
        {
            var index = str?.IndexOf("/");
            if (index == null || index < 0)
            {
                throw new ExFrac("Строка пуста!");
            }

            var num = str.Substring(0, index.GetValueOrDefault());
            var den = str.Substring(index.GetValueOrDefault() + 1);
            var numInt = Convert.ToInt32(num);
            var denInt = Convert.ToInt32(den);
            if (denInt == 0)
            {
                throw new ExFrac("Деление на ноль невозможно!");
            }

            Numerator = numInt;
            Denominator = denInt;
        }

        public TFrac Copy()
        {
            return (TFrac)this.MemberwiseClone();
        }
        /// <summary>
        /// Сумма
        /// </summary>
        public TFrac Add(TFrac b)
        {
            TFrac otv = b.Copy();
            if (this.Denominator == b.Denominator)
            {
                otv.denominator = this.Denominator;
                otv.numerator = this.Numerator + b.Numerator;
            }
            else
            {
                int nok = NOK(Convert.ToInt32(this.Denominator), Convert.ToInt32(b.Denominator));
                otv.denominator = nok;
                otv.numerator = this.Numerator * (nok / this.Denominator) + b.Numerator * (nok / b.Denominator);
            }
            return Norm(otv);
        }
        /// <summary>
        /// Разность
        /// </summary>
        public TFrac Difference(TFrac A, TFrac B)
        {
            //if (A.Numerator == 0) return Multiplication(Norm(B), new TFrac(-1, 1));
            if (B.Numerator == 0) return Norm(A);
            TFrac otv = A.Copy();
            TFrac a = Norm(A), b = Norm(B);
            if (a.Denominator == b.Denominator)
            {
                otv.Denominator = a.Denominator;
                otv.Numerator = a.Numerator - b.Numerator;
            }
            else
            {
                int nok = NOK(Convert.ToInt32(a.Denominator), Convert.ToInt32(b.Denominator));
                otv.Denominator = nok;
                otv.Numerator = a.Numerator * (nok / a.Denominator) - b.Numerator * (nok / b.Denominator);
            }
            return Norm(otv);
        }
        /// <summary>
        /// Произведение
        /// </summary>
        public TFrac Multiplication(TFrac a, TFrac b)
        {
            TFrac otv = a.Copy();
            otv.Denominator = a.Denominator * b.Denominator;
            otv.Numerator = a.Numerator * b.Numerator;
            return otv;
        }

        /// <summary>
        /// Деление
        /// </summary>
        public TFrac Division(TFrac a, TFrac b)
        {
            TFrac otv = a.Copy();
            otv.Denominator = a.Denominator * b.Numerator;
            otv.Numerator = a.Numerator * b.Denominator;
            return Norm(otv);
        }

        /// <summary>
        /// Квадрат
        /// </summary>
        public TFrac Square()
        {
            return Multiplication(this, this);
        }

        /// <summary>
        /// Обратное
        /// </summary>
        public TFrac Reverse()
        {
            TFrac otv = this.Copy();
            otv.Denominator = this.Numerator;
            otv.Numerator = this.Denominator;
            return otv;
        }
        /// <summary>
        /// Минус
        /// </summary>
        public TFrac Minus()
        {
            TFrac otv = this.Copy();
            otv.Denominator = this.Denominator;
            otv.Numerator = 0 - this.Numerator;
            return otv;
        }

        /// <summary>
        /// Равно
        /// </summary>
        public bool Ravn(TFrac d)
        {
            TFrac otv = Difference(this, d);
            if (otv.Numerator == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Больше
        /// </summary>
        public bool More(TFrac d)
        {
            TFrac otv = Difference(this, d);
            if ((otv.Numerator > 0 && otv.Denominator > 0)
                || (otv.Numerator < 0 && otv.Denominator < 0))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// ВзятьЧислительЧисло
        /// </summary>
        public int GetNumeratorNumber()
        {
            return numerator;
        }

        /// <summary>
        /// ВзятьЗнаменательЧисло
        /// </summary>
        public int GetDenominatorNumber()
        {
            return denominator;
        }
        /// <summary>
        /// ВзятьЧислительСтрока
        /// </summary>
        public string GetNumeratorString()
        {
            return numerator.ToString();
        }

        /// <summary>
        /// ВзятьЗнаменательСтрока
        /// </summary>
        public string GetDenominatorString()
        {
            return denominator.ToString();
        }
        /// <summary>
        /// ВзятьДробьСтрока
        /// </summary>
        public string GetString()
        {
            return numerator + "/" + denominator;
        }

        private int NOK(int a, int b) { return (a * b) / gcd(a, b); }
        private int gcd(int a, int b) { return a != 0 ? gcd(b % a, a) : b; }
        public int NOD(List<int> list)
        {
            if (list.Count == 0) return 0;
            int i;
            int gcd = list[0];
            for (i = 0; i < list.Count - 1; i++)
                gcd = NOD(gcd, list[i + 1]);
            return gcd;
        }
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private TFrac Norm(TFrac SimpleFractions)
        {
            TFrac fractions = SimpleFractions;
            if (fractions.Numerator == 0) { fractions.Denominator = 1; return fractions; }
            fractions = Reduction(fractions);
            if (NOD(new List<int> { fractions.Numerator, fractions.Denominator }) != 0)
            {
                int nod = NOD(new List<int> { fractions.Numerator, fractions.Denominator });
                fractions.Numerator /= nod;
                fractions.Denominator /= nod;
            }
            if (fractions.Denominator < 0)
            {
                fractions.Numerator *= -1;
                fractions.Denominator *= -1;
            }
            return fractions;
        }

        public TFrac Reduction(TFrac SimpleFractions)
        {
            TFrac a = SimpleFractions;
            if ((SimpleFractions.Denominator < 0 && SimpleFractions.Numerator >= 0) || (SimpleFractions.Numerator < 0 && SimpleFractions.Denominator < 0))
            {
                SimpleFractions.Numerator *= -1;
                SimpleFractions.Denominator *= -1;
            }
            var nod = NOD(new List<int> { a.Numerator, a.Denominator });
            if (nod != 1)
            {
                a.Denominator /= nod;
                a.Numerator /= nod;
            }
            return a;
        }
    }
}
