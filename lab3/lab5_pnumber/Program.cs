using System;
using lab5_pnumber.pnumber;

namespace lab5_pnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1283,22";
            string b = "15";
            string c = "2";

            string extend = "0,0";
            IPNumber iP = new IPNumber(a, b, c);

            string result = iP.Sqr().GetPString();


            Console.WriteLine(result);
        }
    }
}
