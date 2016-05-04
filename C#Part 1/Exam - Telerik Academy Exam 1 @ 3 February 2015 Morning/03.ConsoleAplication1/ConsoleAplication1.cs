using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.ConsoleAplication1
{
    class ConsoleAplication1
    {
        static void Main(string[] args)
        {
            int countNumbers = 0;
            BigInteger resultTillTen = 1;
            BigInteger resultAfterTen = 1;
            string number = Console.ReadLine();

            while (number != "END")
            {
                if ((number == "0") || (countNumbers % 2 == 0))
                {
                    countNumbers++;
                    number = Console.ReadLine();
                    continue;
                }

                if ((countNumbers <= 10))
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] != '0')
                        {
                            resultTillTen *= (number[i] - '0');
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] != '0')
                        {
                            resultAfterTen *= (number[i] - '0');
                        }
                    }
                }
                countNumbers++;
                number = Console.ReadLine();
            }
            Console.WriteLine(resultTillTen);
            if (countNumbers > 10)
            {
                Console.WriteLine(resultAfterTen);
            }
        }
    }
}
