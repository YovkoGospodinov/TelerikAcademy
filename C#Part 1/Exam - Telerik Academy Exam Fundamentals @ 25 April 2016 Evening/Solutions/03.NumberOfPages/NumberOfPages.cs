using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NumberOfPages
{
    class NumberOfPages
    {
        static void Main(string[] args)
        {
            int digitsNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int pages = 0;

            for (int i = 1; i <= digitsNumber; i++)
            {
                if (i < 10)
                {
                    sum += 1;
                }
                if ((i >= 10) && (i < 100))
                {
                    sum += 2;
                }
                if ((i >= 100) && (i < 1000))
                {
                    sum += 3;
                }
                if ((i >= 1000) && (i < 10000))
                {
                    sum += 4;
                }
                if ((i >= 10000) && (i < 100000))
                {
                    sum += 5;
                }
                if ((i >= 100000) && (i < 1000000))
                {
                    sum += 6;
                }
                if (i >= 1000000)
                {
                    sum += 7;
                }
                if (sum == digitsNumber)
                {
                    pages = i;
                }
            }
            Console.WriteLine(pages);
        }
    }
}

