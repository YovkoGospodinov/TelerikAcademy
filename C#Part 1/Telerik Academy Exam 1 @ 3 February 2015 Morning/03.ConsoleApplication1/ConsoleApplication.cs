using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.ConsoleApplication1
{
    class ConsoleApplication
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = 0;
            BigInteger resultToTen = 1;
            BigInteger resultAfterTen = 1;
            while (input != "END")
            {
                if (count <= 10)
                {
                    if (count % 2 != 0)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            int digit = int.Parse(Convert.ToString(input[i]));
                            if (digit != 0)
                            {
                                resultToTen *= digit;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        int digit = int.Parse(Convert.ToString(input[i]));
                        if (digit != 0)
                        {
                            resultAfterTen *= digit;
                        }
                    }
                }
                count++;
                input = Console.ReadLine();
            }
            Console.WriteLine(resultToTen);
            if (count > 10)
            {
                Console.WriteLine(resultAfterTen);
            }
        }
    }
}
