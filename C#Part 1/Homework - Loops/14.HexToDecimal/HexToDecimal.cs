using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();
            long decimalNumber = 0;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                switch (hexNumber[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        decimalNumber += long.Parse(hexNumber[i].ToString()) * (long)Math.Pow(16, hexNumber.Length - 1 - i);
                        break;
                    case 'A':
                        decimalNumber += 10 * (long)Math.Pow(16, hexNumber.Length - 1 - i); break;
                    case 'B':
                        decimalNumber += 11 * (long)Math.Pow(16, hexNumber.Length - 1 - i); break;
                    case 'C':
                        decimalNumber += 12 * (long)Math.Pow(16, hexNumber.Length - 1 - i); break;
                    case 'D':
                        decimalNumber += 13 * (long)Math.Pow(16, hexNumber.Length - 1 - i); break;
                    case 'E':
                        decimalNumber += 14 * (long)Math.Pow(16, hexNumber.Length - 1 - i); break;
                    case 'F':
                        decimalNumber += 15 * (long)Math.Pow(16, hexNumber.Length - 1 - i); break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            Console.WriteLine(decimalNumber);
        }
    }
}

