using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ThreeNumbers
{
    class ThreeNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggestNumber = 0;
            int smallestNumber = 0;
            double average = (firstNumber + secondNumber + thirdNumber) / 3.0d;

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                biggestNumber = firstNumber;
                if (secondNumber >= thirdNumber)
                {
                    smallestNumber = thirdNumber;
                }
                else
                {
                    smallestNumber = secondNumber;
                }
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                biggestNumber = secondNumber;
                if (firstNumber >= thirdNumber)
                {
                    smallestNumber = thirdNumber;
                }
                else
                {
                    smallestNumber = firstNumber;
                }
            }
            else
            {
                biggestNumber = thirdNumber;
                if (firstNumber >= secondNumber)
                {
                    smallestNumber = secondNumber;
                }
                else
                {
                    smallestNumber = firstNumber;
                }
            }

            Console.WriteLine(biggestNumber);
            Console.WriteLine(smallestNumber);
            Console.WriteLine("{0:F2}", Math.Round(average, 2));
        }
    }
}
