using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double weightEarth = double.Parse(Console.ReadLine());
            double moonGravity = 0.17d;
            Console.WriteLine("{0:F3}", moonGravity * weightEarth);
        }
    }
}
