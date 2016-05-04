using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Maslan
{
    class Maslan
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int transformation = 0;
            while (true)
            {
                if (input.Length <= 1 || transformation >= 10)
                {
                    break;
                }

                BigInteger product = 1;
                while (true)
                {
                    if (input.Length <= 1)
                    {
                        break;
                    }
                    input = input.Remove(input.Length - 1);
                    int sum = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum += int.Parse(Convert.ToString(input[i]));
                        }
                    }
                    if (sum != 0)
                    {
                        product *= sum;
                    }
                }
                transformation++;
                input = product.ToString();
            }
            if (transformation < 10)
            {
                Console.WriteLine(transformation);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
