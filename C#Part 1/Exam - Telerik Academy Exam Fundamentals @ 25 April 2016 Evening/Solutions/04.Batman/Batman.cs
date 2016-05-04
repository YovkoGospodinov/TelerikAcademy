using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Batman
{
    class Batman
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char symbol = (char)Console.Read();

            for (int i = 0; i < size / 2; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write(new string(symbol, size - i));

                if (i == (size / 2) - 1)
                {
                    Console.Write(new string(' ', (size - 3) / 2));
                    Console.Write("{0}{1}{0}", symbol, ' ');
                    Console.Write(new string(' ', (size - 3) / 2));
                }
                else
                {
                    Console.Write(new string(' ', size));
                }
                
                Console.Write(new string(symbol, size - i));

                Console.WriteLine();
            }

            for (int i = 0; i < size / 3; i++)
            {
                Console.Write(new string(' ', size / 2));
                Console.Write(new string(symbol, (size * 3) - 2 * (size / 2)));
                Console.Write(new string(' ', size / 2));

                Console.WriteLine();
            }

            for (int i = 0; i < size / 2; i++)
            {
                Console.Write(new string(' ', size + 1 + i));
                Console.Write(new string(symbol, (size - 2) - (2 * i)));
                Console.Write(new string(' ', size + 1 + i));

                Console.WriteLine();
            }
        }
    }
}
