using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.SaddyKopper
{
    class SaddyKopper
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int trasformations = 0;
            while (input.Length > 1 && trasformations < 10)
            {
                BigInteger product = 1;
                while (input.Length > 1)
                {
                    //input = input.Remove(input.Length - 1);
                    input = input.Substring(0, input.Length - 1);
                    int sum = 0;
                    for (int i = 0; i < input.Length; i += 2)
                    {
                        //sum += int.Parse(Convert.ToString(input[i]));
                        sum += (input[i] - '0');
                    }
                    product *= sum;
                }
                trasformations++;
                input = product.ToString();
            }
            if (trasformations < 10)
            {
                Console.WriteLine(trasformations);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
