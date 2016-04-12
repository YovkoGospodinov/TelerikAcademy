using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double maxDelimer = Math.Sqrt(number);
            bool isPrime = true;
            if (number > 1 && number < 101)
            {
                for (int i = 2; i <= maxDelimer; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }            
        }
    }
}
