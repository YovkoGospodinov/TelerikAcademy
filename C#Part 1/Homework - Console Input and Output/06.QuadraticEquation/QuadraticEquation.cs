using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double firtsNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(secondNumber, 2) - (4 * firtsNumber * thirdNumber);            

            if (discriminant > 0)
            {
                double firstRealRoot = (-secondNumber + Math.Sqrt(discriminant)) / (2 * firtsNumber);
                double secondRealRoot = (-secondNumber - Math.Sqrt(discriminant)) / (2 * firtsNumber);
                if (firstRealRoot > secondRealRoot)
                {
                    Console.WriteLine("{0:F2}{1}{2:F2}", secondRealRoot, Environment.NewLine, firstRealRoot);
                }
                else
                {
                    Console.WriteLine("{0:F2}{1}{2:F2}", firtsNumber, Environment.NewLine, secondRealRoot);
                }
            }
            else if (discriminant == 0)
            {
                double realRoot = -(secondNumber / (2 * firtsNumber));
                Console.WriteLine("{0:F2}", realRoot);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
