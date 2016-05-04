using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersianRugs
{
    class PersianRugs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;

            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("{0}{1}{2}{3}{0}", new string('#', i), "\\", new string(' ', width - 2 * (1 + i)), "/");
                int dots = (width - 2 * (1 + i)) - 2 * d;

                Console.Write(new string('#', i));
                Console.Write("\\");

                if (dots > 1)
                {
                    Console.Write(new string(' ', d));
                    Console.Write(new string('\\', 1));
                    Console.Write(new string('.', dots - 2));
                    Console.Write(new string('/', 1));
                    Console.Write(new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', width - 2 * (1 + i)));
                }

                Console.Write("/");
                Console.Write(new string('#', i));

                Console.WriteLine();
            }

            Console.WriteLine("{0}{1}{0}", new string('#', n), "X");

            for (int i = n - 1; i >= 0; i--)
            {
                //Console.WriteLine("{0}{1}{2}{3}{0}", new string('#', i), "/", new string(' ', width - 2 * (1 + i)), "\\");
                int dots = (width - 2 * (1 + i)) - 2 * d;

                Console.Write(new string('#', i));
                Console.Write("/");

                if (dots > 1)
                {
                    Console.Write(new string(' ', d));
                    Console.Write(new string('/', 1));
                    Console.Write(new string('.', dots - 2));
                    Console.Write(new string('\\', 1));
                    Console.Write(new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', width - 2 * (1 + i)));
                }

                Console.Write("\\");
                Console.Write(new string('#', i));

                Console.WriteLine();
            }
        }
    }
}
