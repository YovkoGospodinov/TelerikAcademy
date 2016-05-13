using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstLargerNeighbours
{
    class FirstLargerNeighbours
    {
        private static int FirstLargerThanNeighbours(int[] numbersSuquance)
        {
            for (int i = 1; i < numbersSuquance.Length - 2; i++)
            {
                if (numbersSuquance[i] > numbersSuquance[i - 1] && numbersSuquance[i] > numbersSuquance[i + 1])
                {
                    return Array.IndexOf(numbersSuquance, numbersSuquance[i]);
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            int indexOfFirstLargerThanNeighbours = FirstLargerThanNeighbours(numbers);
            Console.WriteLine(indexOfFirstLargerThanNeighbours);
        }
    }
}
