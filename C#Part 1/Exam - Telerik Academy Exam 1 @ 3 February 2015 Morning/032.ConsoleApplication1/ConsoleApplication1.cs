using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _032.ConsoleApplication1
{
    class ConsoleApplication1
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countNumbers = 0;
            BigInteger productTillTen = 1;
            BigInteger productAfterTen = 1;

            while (true)
            {
                if (input == "END")
                {
                    break;
                }
                long number = long.Parse(input);
                if (number == 0 || countNumbers % 2 == 0)
                {
                    countNumbers++;
                    input = Console.ReadLine();
                    continue;
                }

                if (countNumbers <= 10)
                {
                    long innerProduct = 1;
                    while (number > 0)
                    {
                        long digit = number % 10;
                        if (number % 10 != 0)
                        {
                            innerProduct *= number % 10;
                        }
                        number /= 10;
                    }
                    productTillTen *= innerProduct;
                }
                else
                {
                    long innerProduct = 1;
                    while (number > 0)
                    {
                        long digit = number % 10;
                        if (number % 10 != 0)
                        {
                            innerProduct *= number % 10;
                        }
                        number /= 10;
                    }
                    productAfterTen *= innerProduct;
                }
                countNumbers++;
                input = Console.ReadLine();
            }
            Console.WriteLine(productTillTen);
            if (countNumbers > 10)
            {
                Console.WriteLine(productAfterTen);
            }
        }
    }
}
