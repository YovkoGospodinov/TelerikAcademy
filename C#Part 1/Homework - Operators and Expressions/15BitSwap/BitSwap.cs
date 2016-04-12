using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int pBitStartPossition = int.Parse(Console.ReadLine());
            int qBitStartPossition = int.Parse(Console.ReadLine());
            int sequenceOfBits = int.Parse(Console.ReadLine());

            int minNumber = Math.Min(pBitStartPossition, qBitStartPossition);
            int maxNumber = Math.Max(pBitStartPossition, qBitStartPossition);

            string strMask = new string('1', sequenceOfBits);
            uint mask = Convert.ToUInt32(strMask, 2);

            uint lowerBits = (number & (mask << minNumber)) >> minNumber;
            uint higherBiths = (number & (mask << maxNumber)) >> maxNumber;

            number &= ~(mask << minNumber);
            number &= ~(mask << maxNumber);

            number |= (lowerBits << maxNumber);
            number |= (higherBiths << minNumber);

            Console.WriteLine(number);
        }
    }
}
