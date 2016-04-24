using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            long evenNumbersProduct = 1;
            long oddNumbersProduct = 1;

            for (int i = 0; i < numbersCount; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbersProduct *= numbers[i];
                }
                else
                {
                    oddNumbersProduct *= numbers[i];
                }
            }

            if (evenNumbersProduct == oddNumbersProduct)
            {
                Console.WriteLine("yes {0}", evenNumbersProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", evenNumbersProduct, oddNumbersProduct);
            }
        }
    }
}
