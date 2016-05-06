using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxIncrSeq
{
    class MaxIncrSeq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            int maxSequence = 1;
            int currentSequence = 1;
            int sequenceNumber = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (sequenceNumber < intArray[i + 1])
                {
                    currentSequence++;
                    sequenceNumber = intArray[i + 1];
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
                else
                {
                    currentSequence = 1;
                    sequenceNumber = intArray[i + 1];
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
