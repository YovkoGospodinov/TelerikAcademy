using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    class IntegerCalculations
    {
        private static double Sum(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static decimal Product(int[] numbers)
        {
            decimal product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }

        private static double Average(int[] numbers)
        {
            return Sum(numbers) / numbers.Length;
        }
        private static double Minimum(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return secondNumber;
            }
            return firstNumber;
        }

        private static double Maximum(double firstNumber, double secondNumber)
        {
            if (secondNumber > firstNumber)
            {
                return secondNumber;
            }
            return firstNumber;
        }
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Minimum(numbers[0], Minimum(numbers[1], Minimum(numbers[2], Minimum(numbers[3], numbers[4])))));
            Console.WriteLine(Maximum(numbers[0], Maximum(numbers[1], Maximum(numbers[2], Maximum(numbers[3], numbers[4])))));
            Console.WriteLine("{0:F2}", Average(numbers));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Product(numbers));
        }
    }
}
