using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FirTree
{
    class FirTree
    {
        static void Main()
        {
            int hight = int.Parse(Console.ReadLine());
            int width = 2 * hight - 3;

            for (int i = 0; i < hight - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - 1) / 2 - i), new string('*', 1 + 2 * i));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', (width - 1) / 2), '*');            
        }
    }
}
