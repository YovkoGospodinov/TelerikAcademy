using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            int sum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(intArray);

            for (int i = 0; i < k; i++)
            {
                sum += intArray[intArray.Length - k + i];
            }
            Console.WriteLine(sum);
        }
    }
}
