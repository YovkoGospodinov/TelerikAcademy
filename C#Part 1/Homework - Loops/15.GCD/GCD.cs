using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(' ');
            int firstNumber = int.Parse(input[0]);
            int secondNumber = int.Parse(input[1]);
            int reminder = 1;
            int delimer = 0;
            int biggerNumber = 0;
            int gcd = 0;

            if (firstNumber >= secondNumber)
            {
                biggerNumber = firstNumber;
                delimer = secondNumber;
            }
            else
            {
                biggerNumber = secondNumber;
                delimer = firstNumber;
            }
            while (true)
            {
                reminder = biggerNumber % delimer;
                biggerNumber = delimer;
                if (reminder == 0)
                {
                    gcd = delimer;
                    break;
                }
                delimer = reminder;
            }
            Console.WriteLine(gcd);
        }
    }
}
