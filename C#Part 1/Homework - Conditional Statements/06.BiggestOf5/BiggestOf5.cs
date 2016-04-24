using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggestOf5
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double fourthNumber = double.Parse(Console.ReadLine());
            double fifthNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && firstNumber >= fifthNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
            {
                Console.WriteLine(thirdNumber);
            }
            else if (fourthNumber >= firstNumber && fourthNumber >= secondNumber && fourthNumber >= thirdNumber && fourthNumber >= fifthNumber)
            {
                Console.WriteLine(fourthNumber);
            }
            else
            {
                Console.WriteLine(fifthNumber);
            }
        }
    }
}

