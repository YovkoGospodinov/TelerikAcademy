using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecNumberToHex
{
    class DecNumberToHex
    {
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
            long decNumber = long.Parse(Console.ReadLine());
            string hexNumber = DecToHex(decNumber);
            Console.WriteLine(hexNumber);
        }
    }
}
