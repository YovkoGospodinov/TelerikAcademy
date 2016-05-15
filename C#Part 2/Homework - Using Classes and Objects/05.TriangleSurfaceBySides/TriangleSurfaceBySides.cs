using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TriangleSurfaceBySides
{
    class TriangleSurfaceBySides
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());

            double perimeter = (firstSide + secondSide + thirdSide) / 2;

            double surface = Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
