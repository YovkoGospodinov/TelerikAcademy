using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SearchInBits
{
    class SearchInBits
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int count = 0;
            int searcheBits = s & 15;
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                for (int j = 0; j < 27; j++)
                {
                    int tracedBits = number & (15 << j);
                    tracedBits = tracedBits >> j;
                    if (tracedBits == searcheBits)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
