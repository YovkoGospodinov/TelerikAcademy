using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class Numbers
    {
        static void Main()
        {
            int[] sequenceNumbers = new int[12] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100 };
            int lastNumber = 1;
            bool isSequence = true;
            for (int i = 1; i < 11; i++)
            {
                string input = Console.ReadLine();
                try
                {
                    int number = int.Parse(input);
                    if (lastNumber >= number)
                    {
                        throw new FormatException("Exception");
                    }
                    lastNumber = number;
                    sequenceNumbers[i] = number;
                }
                catch (FormatException)
                {
                    isSequence = false;
                }
            }
            if (isSequence)
            {
                Console.WriteLine(string.Join(" < ", sequenceNumbers));
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
