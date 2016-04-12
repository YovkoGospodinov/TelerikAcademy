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
            double distance = Math.Sqrt(Math.Pow(pointXCoordinate - 1, 2) + Math.Pow(pointYCoordinate - 1, 2));

            if (distance > 1.5d)
            {
                isInsideCircle = false;
            }

            if (isInsideCircle) //inside circle
            {
                if ((pointXCoordinate <= 5) && (pointXCoordinate >= -1) && (pointYCoordinate >= -1) && (pointYCoordinate <= 1))//inside rectangle
                {
                    Console.WriteLine("{0} {1}", "inside circle", "inside rectangle");
                }
                else
                {
                    Console.WriteLine("{0} {1}", "inside circle", "outside rectangle");
                }
                
            }
            else //outside circle
            {
                if ((pointXCoordinate <= 5) && (pointXCoordinate >= -1) && (pointYCoordinate >= -1) && (pointYCoordinate <= 1))//inside rectangle
                {
                    Console.WriteLine("{0} {1}", "outside circle", "inside rectangle");
                }
                else
                {
                    Console.WriteLine("{0} {1}", "outside circle", "outside rectangle");
                }
                
            }
        }
    }
}
