using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DiamondTrolls_Paint
{
    class DiamondTrolls
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = (6 + ((n - 3) / 2) * 3);//

            Console.WriteLine("{0}{1}{0}", new string('.', (width - n) / 2), new string('*', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', n / 2 - i), '*', new string('.', n / 2 + i));
            }

            Console.WriteLine(new string('*', width));

            for (int i = n - 1; i > 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', n - i), '*', new string('.', i - 1));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', (width - 1) / 2), '*');
        }
    }
}
