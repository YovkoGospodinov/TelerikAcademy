using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ThreeNumbers
{
    class Numbers
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber));
            Console.WriteLine(Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber));

            double avarage = (firstNumber + secondNumber + thirdNumber) / 3d;

            Console.WriteLine("{0:F2}", avarage);

        }
    }
}
