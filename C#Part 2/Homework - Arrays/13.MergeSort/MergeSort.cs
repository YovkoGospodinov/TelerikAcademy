using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(intArray);
            foreach (int number in intArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
