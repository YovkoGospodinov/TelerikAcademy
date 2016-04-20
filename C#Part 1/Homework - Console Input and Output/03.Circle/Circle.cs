using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        }
    }
}
