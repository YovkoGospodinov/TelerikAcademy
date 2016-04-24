using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                List<int> digits = new List<int>();

                while (true)
                {
                    if (number == 0)
                    {
                        break;
                    }
                    digits.Add(number % 2);
                    number /= 2;
                }
                digits.Reverse();
                foreach (var digit in digits)
                {
                    Console.Write(digit);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
