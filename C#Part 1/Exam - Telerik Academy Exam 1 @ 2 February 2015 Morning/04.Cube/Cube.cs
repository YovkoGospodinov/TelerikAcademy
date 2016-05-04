using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cube
{
    class Cube
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = 2 * n - 1;

            Console.WriteLine("{0}{1}", new string(' ', n - 1), new string(':', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}", new string(' ', n - 2 - i), ":", new string('/', n - 2), new string('X', i));
            }

            Console.WriteLine("{0}{1}{2}", new string(':', n), new string('X', n - 2), new string(':', 1));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}", ":", new string(' ', n - 2), new string('X', n - 3 - i));
            }

            Console.WriteLine("{0}{1}", new string(':', n), new string(' ', n - 1));
        }
    }
}
