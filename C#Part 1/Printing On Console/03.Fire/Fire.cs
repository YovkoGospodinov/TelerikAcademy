using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fire
{
    class Fire
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2 - 1 - i), '#', new string('.', 2 * i));
            }

            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), '#', new string('.', n - 2 - 2 * i));
            }

            Console.WriteLine(new string('-', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{0}", new string('.', i), new string('\\', n / 2 - i), new string('/', n / 2 - i));
            }
        }
    }
}
