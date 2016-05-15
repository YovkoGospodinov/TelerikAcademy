using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumIntegers
{
    class SumIntegers
    {
        public static long CalculateSum(string sequence)
        {
            int[] numbers = sequence.Split(' ').Select(int.Parse).ToArray();

            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long result = CalculateSum(input);
            Console.WriteLine(result);
        }
    }
}
