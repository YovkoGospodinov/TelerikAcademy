using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = number / 100;
            int thirdDigit = newNumber % 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("{0}", "true");
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", "false", " ", thirdDigit);
            }
        }
    }
}
