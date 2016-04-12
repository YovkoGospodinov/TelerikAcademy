using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 7;
            uint firstBitSequence = number & (mask << 3);
            firstBitSequence >>= 3;
            uint secondBitSequence = number & (mask << 24);
            secondBitSequence >>= 24;

            //Console.WriteLine(Convert.ToString(firstBitSequence,2));
            //Console.WriteLine(Convert.ToString(secondBitSequence, 2));

            number = number & ~(mask << 3);

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            number = number & ~(mask << 24);

            //Console.WriteLine(Convert.ToString(number,2).PadLeft(32, '0'));

            number = number | (firstBitSequence << 24);

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            number = number | (secondBitSequence << 3);

            Console.WriteLine(number);
        }
    }
}
