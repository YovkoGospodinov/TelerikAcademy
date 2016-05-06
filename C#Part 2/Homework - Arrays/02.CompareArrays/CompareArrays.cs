using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            bool isEqual = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
