using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BinaryShort
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}
