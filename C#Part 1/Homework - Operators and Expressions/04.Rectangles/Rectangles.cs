using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = widht * hight;
            double perimeter = 2 * (widht + hight);

            Console.WriteLine("{0:F2}{1}{2:F2}", area, " ", perimeter);
        }
    }
}
