using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        private static int CountNumberAppearance(int[] numbersSequance, int number)
        {
            int countAppearance = 0;
            for (int i = 0; i < numbersSequance.Length; i++)
            {
                if (numbersSequance[i] == number)
                {
                    countAppearance++;
                }
            }
            return countAppearance;
        }
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());
            int accuaranceCount = CountNumberAppearance(numbers, searchedNumber);
            Console.WriteLine(accuaranceCount);
        }
    }
}
