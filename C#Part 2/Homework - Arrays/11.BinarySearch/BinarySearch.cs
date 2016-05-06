using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            int leftIndex = 0;
            int rightIndex = n - 1;
            int middleIndex = 0;
            int result = - 1;

            while (leftIndex <= rightIndex)
            {
                middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (intArray[middleIndex] == x)
                {
                    result = middleIndex;
                    break;
                }
                else if (intArray[middleIndex] > x)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }

            }
            Console.WriteLine(result);
        }
    }
}
