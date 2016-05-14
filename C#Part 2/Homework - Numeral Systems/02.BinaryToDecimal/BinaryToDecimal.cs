using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
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

        static void Main(string[] args)
        {
            string binNumber = Console.ReadLine();
            long decNumber = BinToDec(binNumber);
            Console.WriteLine(decNumber);
        }
    }
}
