using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        private static int LargerNumberBetweenNeighbours(int[] numbersSequance)
        {
            int largerNumbersCount = 0;
            for (int i = 0; i < numbersSequance.Length; i++)
            {
                if (i != 0 && i != numbersSequance.Length - 1)
                {
                    if (numbersSequance[i] > numbersSequance[i - 1] && numbersSequance[i] > numbersSequance[i + 1])
                    {
                        largerNumbersCount++;
                    }
                    else
                    {
                        continue;
                    }
                }
                //The belong code check if we go through the first and the last element int the array.
                //else if (i == 0)
                //{
                //    if (numbersSequance[i] > numbersSequance[i + 1])
                //    {
                //        largerNumbersCount++;
                //    }
                //    else
                //    {
                //        continue;
                //    }
                //}
                //else if (i == numbersSequance.Length - 1)
                //{
                //    if (numbersSequance[i] > numbersSequance[i - 1])
                //    {
                //        largerNumbersCount++;
                //    }
                //    else
                //    {
                //        continue;
                //    }
                //}
            }
            return largerNumbersCount;
        }
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(LargerNumberBetweenNeighbours(numbers));
        }
    }
}
