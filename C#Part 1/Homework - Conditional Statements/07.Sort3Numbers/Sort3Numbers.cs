using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else if (thirdNumber >= secondNumber && thirdNumber >= firstNumber)
            {
                if (secondNumber >= firstNumber)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
                }
            }
        }
    }
}
