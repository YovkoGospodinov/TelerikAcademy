using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("0");
            }
            else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                Console.WriteLine("+");
            }
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                Console.WriteLine("-");
            }
            else if (firstNumber < 0)
            {
                if (secondNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else if (secondNumber < 0)
            {
                if (firstNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else if (thirdNumber < 0)
            {
                if (firstNumber > 0 && secondNumber > 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}
