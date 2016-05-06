using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            int startIndex = 0;
            int endIndex = 0;
            int look = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (look == sum)
                {
                    break;
                }
                else
                {
                    look = intArray[i];
                }

                for (int j = i + 1; j < intArray.Length - 1; j++)
                {
                    look += intArray[j];
                    if (look == sum)
                    {
                        startIndex = i;
                        endIndex = j;
                        break;
                    }
                    else if (look > sum)
                    {
                        break;
                    }
                }
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(intArray[i]);
                if (i != endIndex)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
