using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double number = 0;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] == '1')
                {
                    number += Math.Pow(2, (input.Length - 1 - i));
                }
            }
            Console.WriteLine(number);
        }
    }
}
