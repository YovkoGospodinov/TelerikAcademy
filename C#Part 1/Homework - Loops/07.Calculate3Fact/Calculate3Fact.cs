using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Calculate3Fact
{
    class Calculate3Fact
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

            BigInteger nkFactorial = 1;
            for (int i = 1; i <= n - k; i++)
            {
                nkFactorial *= i;
            }

            BigInteger result = nFactorial / (kFactorial * nkFactorial);
            Console.WriteLine(result);
        }
    }
}
