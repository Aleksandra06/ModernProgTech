using System;

namespace UEditor
{
    public class TEditor
    {
        public const char SPLIT = ',';
        public const string ZERO = "0,0";

        private string number;
        private int b;
        private int c;
        public TEditor()
        {
            number = ZERO;
            b = 10;
            c = 1;
        }
        public TEditor(int b, int c)
        {
            if (checkOnCountBaseAndC(b, c)) {
                this.b = b;
                this.c = c;
                number = ZERO;
            } else {
                number = ZERO;
                b = 10;
                c = 1;
            }
        }
        public TEditor(string number, int b, int c)
        {
            if (check(number, b, c)) {
                this.number = number;
                this.b = b;
                this.c = c;
            } else {
                this.number = ZERO;
                this.b = 10;
                this.c = 1;
            }
        }
        public bool IsZero()
        {
            return (number.Equals(ZERO));
        }
        public string AddSign() // 0
        {
            if (number[0].Equals('-')) {
                number = number.Substring(1);
            } else {
                number = "-" + number;
            }
            return number;
        }
        public string Add(int a)
        {
            if (checkPoint(number) && c == 1 && number[number.Length - 1] == '0') {
                number = number.Substring(0, number.Length - 2);
                number += a;
                number += ",0";
            } 
            return number;
        }
        public string AddZero() // 1
        {
            if (checkPoint(number) && c == 1 && number[number.Length - 1] == '0') {
                number = number.Substring(0, number.Length - 2);
                number += 0;
                number += ",0";
            }
            return number;
        }
        public string BackSpace() // 2
        {
            if (!number.Equals(ZERO) && number.Length > 2) {
                number = number.Substring(0, number.Length - 1);
                if (number[number.Length - 1].Equals(SPLIT)) {
                    number += "0";
                    c++;
                }
                c--;
            }
            return number;
        }
        public string Clear() // 3
        {
            number = ZERO;
            c = 1;
            return number;
        }
        public string GetNumber() // 4
        {
            return number;
        }
        public string SetNumber(string a)
        {
            if (checkOnBase(a, b) && countC(a) > 0) {
                number = a;
                c = countC(a);
            }
            return number;
        }
        public String Edit(int a)
        {
            
            switch (a) {
                case 0:
                    AddSign();
                    break;
                case 1:
                    AddZero();
                    break;
                case 2:
                    BackSpace();
                    break;
                case 3:
                    Clear();
                    break;
                case 4:
                    GetNumber();
                    break;
            }

            return number;
        }
        private bool check(string a, int b, int c)
        {
            if (!checkOnBase(a, b)) {
                return false;
            }
            if (!checkOnC(a, c)) {
                return false;
            }
            if (!checkOnSymbol(a)) {
                return false;
            }
            if (!checkOnCountBaseAndC(b, c)) {
                return false;
            }
            return true;
        }
        private bool checkOnC(string a, int c)
        {
            if (checkPoint(a) && c > 0) {
                string[] spliter = a.Split(',');
                if (spliter[1].Length == c) {
                    return true;
                }
            }
            if (!checkPoint(a) && c == 0) {
                return true;
            }
            return false;
        }
        private bool checkOnSymbol(string a)
        {
            foreach (char iter in a) {
                if (iter >= 'a' && iter <= 'z') {
                    return false;
                }
            }
            return true;
        }
        private bool checkPoint(string n)
        {
            int i;
            for (i = 0; i < n.Length && n[i] != ','; i++) { }
            if (i < n.Length) {
                return true;
            }
            return false;
        }
        private bool checkOnBase(string a, int b)
        {
            foreach (char iter in a) {
                int move = Math.Abs('A' - iter);
                int iter_int = iter - '0';
                if (iter >= 'A' && iter <= 'Z') {
                    iter_int = 10 + move;
                }
                if (iter == ',') {
                    continue;
                }
                if (iter_int >= b) {
                    return false;
                }
            }
            return true;
        }
        private bool checkOnCountBaseAndC(int b, int c)
        {
            if (b > 1 && b < 17 && c > 0) {
                return true;
            }
            return false;
        }
        public int getC()
        {
            return c;
        }
        public int getB()
        {
            return b;
        }

        private int countC(string a)
        {
            string[] split = a.Split(",");
            return split[1].Length;
        }
    }
}
