using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int primeNumber = 0;

            for (int i = n; i > 1; i--)
            {
                bool isPrime = true;
                for (int j = 2; j < Math.Sqrt(n); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumber = i;
                    break;
                }
            }
            Console.WriteLine(primeNumber);
        }
    }
}
