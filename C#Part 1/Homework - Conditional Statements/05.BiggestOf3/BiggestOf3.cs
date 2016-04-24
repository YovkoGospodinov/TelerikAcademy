using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
