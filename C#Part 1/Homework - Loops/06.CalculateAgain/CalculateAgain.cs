using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            BigInteger kFactorial = 1;
            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }

            BigInteger result = nFactorial / kFactorial;
            Console.WriteLine(result);
        }
    }
}
