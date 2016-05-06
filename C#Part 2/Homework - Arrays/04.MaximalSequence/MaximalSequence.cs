using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[n];
            int maxSequence = 1;
            int currentSequence = 1;

            for (int i = 0; i < n; i++)
            {
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            int sequenceNumber = arrayNumbers[0];
            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {

                if (sequenceNumber == arrayNumbers[i + 1])
                {
                    sequenceNumber = arrayNumbers[i + 1];
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
                else
                {
                    currentSequence = 1;
                    sequenceNumber = arrayNumbers[i + 1];
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
