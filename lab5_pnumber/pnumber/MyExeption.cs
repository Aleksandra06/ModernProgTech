using System;
using System.Collections.Generic;
using System.Text;

namespace pnumber
{
    public class MyExeption : Exception
    {
        MyExeption(string Message) : base(Message)
        {
        }
    }
}
