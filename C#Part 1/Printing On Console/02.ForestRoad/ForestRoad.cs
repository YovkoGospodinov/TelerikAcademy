using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starPlace = 0;
            for (int i = 0; i < 2 * n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == starPlace)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                if (i < n - 1)
                {
                    starPlace++;
                }
                else
                {
                    starPlace--;
                }
                Console.WriteLine();
            }

            //for (int r = 0; r < n; r++)
            //{
            //    for (int c = 0; c < n; c++)
            //    {
            //        if (r == c)
            //        {
            //            Console.Write('*');
            //        }
            //        else
            //        {
            //            Console.Write('.');
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //for (int r = n - 1; r > 0; r--)
            //{
            //    for (int c = 1; c <= n; c++)
            //    {
            //        if (r == c)
            //        {
            //            Console.Write('*');
            //        }
            //        else
            //        {
            //            Console.Write('.');
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}

