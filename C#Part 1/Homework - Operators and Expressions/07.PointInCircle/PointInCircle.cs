using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double pointXCoordinate = double.Parse(Console.ReadLine());
            double pointYCoordinate = double.Parse(Console.ReadLine());
            bool isInsideCircle = true;
            double distance = Math.Sqrt(Math.Pow(pointXCoordinate, 2) + Math.Pow(pointYCoordinate, 2));

            if (distance > 2)
            {
                isInsideCircle = false;
            }

            if (isInsideCircle)
            {
                Console.WriteLine("{0}{1}{2:F2}", "yes", " ", distance);
            }
            else
            {
                Console.WriteLine("{0}{1}{2:F2}", "no", " ", distance);
            }
        }
    }
}
