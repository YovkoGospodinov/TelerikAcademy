using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHex
{
    class BinaryToHex
    {
        public static long BinToDec(string number)
        {
            string temp = number.ToString();
            long sum = 0;
            foreach (char ch in number)
            {
                sum = (ch - '0') + sum * 2;
            }
            return sum;
        }

        public static string DecToHex(long number)
        {
            string hexNumber = "";
            char[] hexSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            while (number != 0)
            {
                hexNumber = hexSymbols[number % 16] + hexNumber;
                number /= 16;
            }
            return hexNumber;
        }

        static void Main(string[] args)
        {
            string binNumber = Console.ReadLine();
            long decNumber = BinToDec(binNumber);
            string hexNumber = DecToHex(decNumber);
            Console.WriteLine(hexNumber);
        }
    }
}
