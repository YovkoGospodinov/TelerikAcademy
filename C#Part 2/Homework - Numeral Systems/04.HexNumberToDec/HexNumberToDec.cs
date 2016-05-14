using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexNumberToDec
{
    class HexNumberToDec
    {
        public static long HexToDec(string hexNumber)
        {
            long decNumber = 0;
            int position = hexNumber.Length - 1;
            foreach (char digit in hexNumber)
            {
                long step = 1;
                if (position != 0)
                {
                    for (int i = 0; i < position; i++)
                    {
                        step *= 16L;
                    }
                }
                char help = '7';
                if (digit > 47 && digit < 58)
                {
                    help = '0';
                }
                decNumber += (digit - help) * step;
                position--;
            }
            return decNumber;


        }
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine().ToUpper();
            long decNumber = HexToDec(hexNumber);
            Console.WriteLine(decNumber);
        }
    }
}
