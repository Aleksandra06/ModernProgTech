using System;

namespace lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 10;
            num = 3;
            double[] array = new double[num];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++) {
                array[i] = random.NextDouble();
            }

            array[0] = 1.2f;
            array[1] = 3.2f;
            array[2] = 4f;

            // function 1
            double result = multOddIndex(array);
            print(array, "Function [1]: Произведение нечетных номеров");
            Console.WriteLine(result);

            // function 2
            Console.WriteLine("Function [2]: Сдвиг");
            int k = random.Next(1, array.Length);
            Console.WriteLine("k = " + k);
            print(array, "Function [2]: Сдвиг вправо ДО");
            shiftRight(array, k);
            print(array, "Function [2]: Сдвиг вправо ПОСЛЕ");

            // function 3

            int b = random.Next(2, 16);
            int num_str = 5;
            string str = "";

            for (int i = 0; i < num_str; i++) {
                char ch;
                int tmp = random.Next(0, b);
                if (tmp < 10) {
                    ch = (char)(tmp + '0');
                } else {
                    ch = (char)(tmp - 10 + 'A');
                }
                str += ch;
            }


            Console.WriteLine("Function[3]: Перевод систем счислений\n Система счисления- > " + b + "\n Строка = " + str);
            int resultConvert = convert(str, b);
            Console.WriteLine(resultConvert);

        }

        public static int convert(string str, int b)
        {
            int tmp;
            int result = 0;
            for (int i = str.Length - 1; i >= 0; i--) {
                if (str[i] >= 'A' && str[i] <= 'Z') {
                    int move = Math.Abs('A' - str[i]);
                    tmp = 10 + move;
                    Console.WriteLine(tmp);
                } else {
                    tmp = str[i] - '0';
                    Console.WriteLine(tmp); }
                result += tmp * (int)Math.Pow(b, str.Length - i - 1); }
            return result;
        }

        public static void shiftRight(double[] array, int k)
        {
            for (int i = 0; i < k; i++) {
                double tmp = array[array.Length - 1];
                for (int j = array.Length - 2; j >= 0; j--) {
                    array[j + 1] = array[j];
                }
                array[0] = tmp;
            }
        }

        public static double multOddIndex(double[] array) // 4 -> 1 3 5
        {
            double mult = 1f;
            for (int i = 1; i < array.Length; i += 2) {
                mult *= array[i];
            }
            return mult;
        }

        public static void print(double[] a, String name)
        {
            Console.WriteLine("Name: " + name + "\nSize: " + a.Length);
            for (int i = 0; i < a.Length; i++) {
                Console.Write("{0:F} ", a[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
