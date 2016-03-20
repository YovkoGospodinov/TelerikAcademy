using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UKFlag
{
    class UKFlag
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{4}{0}", new string('.', i), '\\', new string('.', (n / 2 - 1) - i), '|', '/');
            }

            Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), '*');

            for (int i = n / 2; i > 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{4}{0}", new string('.', i - 1), '/', new string('.', n / 2 - i), '|', '\\');
            }

            //int n = int.Parse(Console.ReadLine());

            //int outerDots = 0;
            //int innerDots = n / 2 - 1;

            //for (int i = 0; i < n / 2; i++)
            //{
            //    Console.Write(new string('.', outerDots));
            //    Console.Write('\\');
            //    Console.Write(new string('.', innerDots));
            //    Console.Write('|');
            //    Console.Write(new string('.', innerDots));
            //    Console.Write('/');                
            //    Console.Write(new string('.', outerDots));
            //    Console.WriteLine();
            //    outerDots++;
            //    innerDots--;
            //}
            //Console.WriteLine("{0}{1}{0}", new string('-', n / 2), '*');

            //outerDots = n / 2 - 1;
            //innerDots = 0;

            //for (int i = n / 2; i > 0; i--)
            //{
            //    Console.Write(new string('.', outerDots));
            //    Console.Write('/');
            //    Console.Write(new string('.', innerDots));
            //    Console.Write('|');
            //    Console.Write(new string('.', innerDots));
            //    Console.Write('\\');
            //    Console.Write(new string('.', outerDots));
            //    Console.WriteLine();
            //    outerDots--;
            //    innerDots++;
            //}
        }
    }
}
