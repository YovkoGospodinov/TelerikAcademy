using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());

            long bitAtPosition = number & (1U << bitPosition);
            bitAtPosition >>= bitPosition;
            Console.WriteLine(bitAtPosition);
        }
    }
}
