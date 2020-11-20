using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab5
{
    //enum partToEdit
    //{
    //    TOP, BOT
    //};

    enum commandType
    {
        etoggleMinus, eaddNumber, eaddZero, edelSymbol,
        eclear, ewriteString
    };

    public class TEditor
    {
        const string separator = "/";
        const string zeroStr = "0/1";
        string frac;
        //partToEdit mode;

        public TEditor()
        {
            frac = zeroStr;
        }

        public bool IsZero()
        {
            if (frac[0] == zeroStr[0] || (frac[0] == '-' && frac[1] == zeroStr[0]))
                return true;
            else return false;
        }

        public string ToggleMinus()
        {
            if (frac[0] == '-')
                frac = frac.Substring(1);
            else
                frac = '-' + frac;
            return frac;
        }

        //partToEdit toggleMode()
        //{
        //    if (mode == partToEdit.TOP)
        //        mode = partToEdit.BOT;
        //    else
        //        mode = partToEdit.TOP;
        //    return mode;
        //}

        public string AddNumber(int a)
        {
            if (a < 0 || a > 9)
                return frac;
            if(frac[0] != '-' && frac[0] != '0')
                frac = a + frac.Substring(2);
            else if (frac[0] == '-' && frac[1] != '0')
                frac = "-" + a + frac.Substring(1);
            else if (frac[0] == '-' && frac[1] == '0')
                frac = "-" + a + frac.Substring(2);
            else if(frac[0] == '0')
                frac = a + frac.Substring(1);
            return frac;
        }

        public string AddZero()
        {
            return AddNumber(0);
        }

        public string DelSymbol()
        {
            if (frac[frac.Length - 2] != separator[0])
            {
                frac = frac.Substring(0, frac.Length-1);
            }

            return frac;
        }

        public string Clear()
        {
            frac = zeroStr;
            return frac;
        }

        string Edit(commandType command)
        {
            switch (command)
            {
                case commandType.etoggleMinus:
                    return this.ToggleMinus();
                case commandType.eaddNumber:
                    {
                        Console.Write("Enter number to add:");
                        int num;
                        num = Console.Read();
                        return this.AddNumber(num);
                        break;
                    }
                case commandType.eaddZero:
                    return this.AddZero();
                    break;
                case commandType.edelSymbol:
                    return this.DelSymbol();
                    break;
                case commandType.eclear:
                    return this.Clear();
                    break;
                case commandType.ewriteString:
                    {
                        Console.Write("Enter string to write:");
                        string inp;
                        inp = Console.ReadLine();
                        return this.WriteString(inp);
                        break;
                    }
                default:
                    return frac;
            }
        }

        public string ReadString()
        {
            return frac;
        }

        public string WriteString(string otherStr)
        {
            frac = otherStr;
            return frac;
        }
    }
}
