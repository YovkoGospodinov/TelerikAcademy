using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            int currentSum = 0;
            int maxSum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                currentSum += intArray[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                else if (currentSum <= 0)
                {
                    currentSum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
