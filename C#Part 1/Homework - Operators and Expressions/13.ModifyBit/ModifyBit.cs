using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());
            int bitValue = int.Parse(Console.ReadLine());
            ulong newNumber = 0;
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            ulong bitAtPosition = number & (1UL << bitPosition);
            bitAtPosition >>= bitPosition;

            if (bitAtPosition == 1)
            {
                if (bitValue == 0)
                {
                    newNumber = number ^ (1UL << bitPosition);
                }
                else
                {
                    newNumber = number;
                }
            }
            else
            {
                if (bitValue == 0)
                {
                    newNumber = number;
                }
                else
                {
                    newNumber = number | (1UL << bitPosition);
                }
            }
            Console.WriteLine(newNumber);
            //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(16, '0'));
        }
    }
}
