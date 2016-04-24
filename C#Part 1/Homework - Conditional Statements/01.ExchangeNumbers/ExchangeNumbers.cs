using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                double thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}
