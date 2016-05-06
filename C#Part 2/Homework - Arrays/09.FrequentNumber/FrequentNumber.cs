using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            int maxFrequentNumber = 0;
            int maxFrequency = 1;

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                int currentFrequency = 1;
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        currentFrequency++;
                    }
                }
                if (currentFrequency > maxFrequency)
                {
                    maxFrequency = currentFrequency;
                    maxFrequentNumber = intArray[i];
                }
            }
            Console.WriteLine("{0} ({1} times)", maxFrequentNumber, maxFrequency);
        }
    }
}
