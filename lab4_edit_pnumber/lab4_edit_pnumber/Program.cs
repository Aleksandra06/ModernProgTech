using System;
using UEditor;

namespace lab4_edit_pnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            TEditor edit = new TEditor("110,0", 13, 1);
            string expected = "110,0";
            string result = edit.SetNumber("1A,2B");
            Console.WriteLine(result);
        }

    }
}
