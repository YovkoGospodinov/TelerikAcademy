using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3rdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint thirdBit = number & (1 << 3);
            thirdBit >>= 3;
            Console.WriteLine(thirdBit);
        }
    }
}
