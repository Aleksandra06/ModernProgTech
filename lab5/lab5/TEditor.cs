using System;

namespace lab5
{
    enum CommandType
    {
        etoggleMinus, eaddNumber, eaddZero, edelSymbol,
        eclear, ewriteString
    };

    public class TEditor
    {
        const string separator = "/";
        const string zeroStr = "0/1";
        string frac;

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

        string Edit(CommandType command)
        {
            switch (command)
            {
                case CommandType.etoggleMinus:
                    return this.ToggleMinus();
                case CommandType.eaddNumber:
                    {
                        Console.Write("Enter number to add:");
                        int num;
                        num = Console.Read();
                        return this.AddNumber(num);
                        break;
                    }
                case CommandType.eaddZero:
                    return this.AddZero();
                    break;
                case CommandType.edelSymbol:
                    return this.DelSymbol();
                    break;
                case CommandType.eclear:
                    return this.Clear();
                    break;
                case CommandType.ewriteString:
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
