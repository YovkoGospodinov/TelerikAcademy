using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleBySideAngle
{
    class TriangleBySideAngle
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double radians = Math.PI / 180 * angle;

            double surface = (firstSide * secondSide) * (Math.Sin(radians) / 2);
            Console.WriteLine("{0:F2}", surface);
        }
    }
}
