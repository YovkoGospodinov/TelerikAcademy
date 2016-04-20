using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int count = 0;

            if (firstNumber > secondNumber)
            {
                int thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            for (int i = firstNumber + 1; i < secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }                
            }
            Console.WriteLine(count);
        }
    }
}
