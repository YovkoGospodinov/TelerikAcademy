using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16.Trailing0InNFac
{
    class Trailing0InNFac
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int countZeroes = 0;
            
            //BigInteger factorialNumber = 1;

            //for (int i = 1; i <= inputNumber; i++)
            //{
            //    factorialNumber *= i;
            //}

            //string factorialString = factorialNumber.ToString();
            
            //for (int i = factorialString.Length - 1; i >= 0; i--)
            //{
            //    if (factorialString[i] == '0')
            //    {
            //        countZeroes++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            
            //Faster way for calculating the zeroes
            int count = 1;

            while (inputNumber / Math.Pow(5, count) >= 1)
            {
                countZeroes += inputNumber / (int)(Math.Pow(5, count));
                count++;
            }

            Console.WriteLine(countZeroes);
        }
    }
}
