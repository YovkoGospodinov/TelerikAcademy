using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int digitsSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int tempNumber = int.Parse(input[i].ToString());
                digitsSum += tempNumber;
            }

            Console.WriteLine(digitsSum);
            Console.WriteLine("{0}{1}{2}{3}", input[3], input[2], input[1], input[0]);
            Console.WriteLine("{0}{1}{2}{3}", input[3], input[0], input[1], input[2]);
            Console.WriteLine("{0}{1}{2}{3}", input[0], input[2], input[1], input[3]);
        }
    }
}
