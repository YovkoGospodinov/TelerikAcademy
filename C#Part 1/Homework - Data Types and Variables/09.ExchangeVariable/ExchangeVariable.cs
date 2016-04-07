using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariable
{
    class ExchangeVariable
    {
        static void Main(string[] args)
        {
            int firsNumber = 5;
            int secondNumber = 10;
            Console.WriteLine("The first number is {0}", firsNumber);
            Console.WriteLine("The second number is {0}", secondNumber);

            int thirdNumber = firsNumber;
            firsNumber = secondNumber;
            secondNumber = thirdNumber;

            Console.WriteLine("The first number is {0}", firsNumber);
            Console.WriteLine("The second number is {0}", secondNumber);
        }
    }
}
