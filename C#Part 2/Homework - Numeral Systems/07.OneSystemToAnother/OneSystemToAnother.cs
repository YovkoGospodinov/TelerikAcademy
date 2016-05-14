using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071.OneSystemToAnother
{
    class OneSystemToAnother
    {
        const string numaricSystem = "0123456789ABCDEF";
        public static long GiveBaseToDecimal(string number, int givenBase)
        {
            long sum = 0;
            foreach (char digit in number)
            {
                if (Char.IsDigit(digit))
                {
                    sum = (digit - '0') + sum * givenBase;
                }
                else
                {
                    sum = (digit - 'A' + 10) + sum * givenBase;
                }
            }
            return sum;
        }

        public static string DecimalToNeededBase(long number, long neededBase)
        {
            string neededSystem = numaricSystem.Substring(0, (int)neededBase);
            string neededNumber = "";
            while (number != 0)
            {
                neededNumber = neededSystem[(int)(number % neededBase)] + neededNumber;
                number /= neededBase;
            }
            return neededNumber;
        }
        static void Main(string[] args)
        {
            int givenRadix = int.Parse(Console.ReadLine());
            string givenNumber = Console.ReadLine();
            long neededRadix = long.Parse(Console.ReadLine());
            long decimalNumber = GiveBaseToDecimal(givenNumber, givenRadix);
            string neededNumber = DecimalToNeededBase(decimalNumber, neededRadix);
            Console.WriteLine(neededNumber);
        }
    }
}
