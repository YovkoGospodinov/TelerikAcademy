using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 5;
            }

            foreach (int number in intArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
