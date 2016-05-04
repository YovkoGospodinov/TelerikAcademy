using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Decoding
{
    class Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                double temp = 0;
                if (input[i] == '@')
                {
                    break;
                }
                else if ((input[i] >= 65 && 90 >= input[i]) || (input[i] >= 97 && 122 >= input[i]))
                {
                    temp = input[i] * salt + 1000;
                }
                else if (input[i] >= 48 && 57 >= input[i])
                {
                    temp = input[i] + salt + 500;
                }
                else
                {
                    temp = input[i] - salt;
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", temp / 100);
                }
                else
                {
                    Console.WriteLine("{0}", temp * 100);
                }
            }

        }
    }
}
