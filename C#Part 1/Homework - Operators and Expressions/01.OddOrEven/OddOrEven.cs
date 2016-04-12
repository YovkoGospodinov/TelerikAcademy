using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isEven = true;

            if (number % 2 != 0)
            {
                isEven = false;
            }

            if (isEven)
            {
                Console.WriteLine("{0}{1}{2}", "even", " ", number);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", "odd", " ", number);
            }
        }
    }
}
