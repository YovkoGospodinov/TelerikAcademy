using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintSequance
{
    class PrintSequance
    {
        static void Main(string[] args)
        {
            int firstNumber = 2;
            int secondNumber = -3;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    firstNumber += 2;
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    secondNumber += -2;
                    Console.WriteLine(secondNumber);
                }
            }
        }
    }
}
