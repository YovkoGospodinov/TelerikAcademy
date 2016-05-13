using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {
        private static int GetMax(int firstNumber, int secondNumber)
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

            int biggestNumber = GetMax(numbers[0], GetMax(numbers[1], numbers[2]));

            Console.WriteLine(biggestNumber);
        }
    }
}
