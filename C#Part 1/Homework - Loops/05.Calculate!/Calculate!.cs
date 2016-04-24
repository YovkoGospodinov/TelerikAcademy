using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_
{
    class Calculate
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1.00;

            for (int i = 1; i <= n; i++)
            {
                double f = 1;
                double a = i;
                while (a > 0)
                {
                    f *= a;
                    a--;
                }
                sum += (f / Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
