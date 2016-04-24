using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            BigInteger n2Factorial = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                n2Factorial *= i;
            }

            BigInteger nPlusFactorial = 1;
            for (int i = 1; i <= n + 1; i++)
            {
                nPlusFactorial *= i;
            }

            BigInteger result = n2Factorial / (nPlusFactorial * nFactorial);
            Console.WriteLine(result);
        }
    }
}
