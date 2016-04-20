using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long firstNumber = 0;
            long secondNumber = 1;
            long thirdNumber = 0;
            if (number == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else 
            {
                Console.Write("{0}, {1}", firstNumber, secondNumber);

                for (int i = 2; i < number; i++)
                {
                    thirdNumber = firstNumber + secondNumber;
                    Console.Write(", {0}", thirdNumber);
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                }
            }            
        }
    }
}
