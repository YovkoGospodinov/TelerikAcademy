using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveElements
{
    class RemoveElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }


            int[] lis = new int[n];

            for (int i = 0; i < lis.Length; i++)
            {
                lis[i] = 1;
            }

            for (int i = 1; i < intArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (intArray[j] <= intArray[i] && lis[i] < lis[j] + 1)
                    {
                        lis[i] = lis[j] + 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", lis));
            Array.Sort(lis);
            int maxSequanceSize = lis[lis.Length - 1];
            int elementRemove = intArray.Length - maxSequanceSize;
            Console.WriteLine(elementRemove);
        }
    }
}
