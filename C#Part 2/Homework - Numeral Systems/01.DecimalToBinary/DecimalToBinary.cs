using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {
        public static string DecToBin(long number)
        {
            string binNumber = "";
            while (number != 0)
            {
                binNumber = number % 2 + binNumber;
                number /= 2;
            }
            return binNumber;
        }

        static void Main(string[] args)
        {
            long decNumber = long.Parse(Console.ReadLine());
            string binNumber = DecToBin(decNumber);
            Console.WriteLine(binNumber);
        }
    }
}
