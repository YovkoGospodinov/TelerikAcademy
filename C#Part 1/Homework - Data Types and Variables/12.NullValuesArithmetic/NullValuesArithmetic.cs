using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? intNumber = null;
            double? doubleNumber = null;
            Console.WriteLine(intNumber);
            Console.WriteLine(doubleNumber);
            intNumber++;
            doubleNumber += 2;
            Console.WriteLine(intNumber);
            Console.WriteLine(doubleNumber);
        }
    }
}
