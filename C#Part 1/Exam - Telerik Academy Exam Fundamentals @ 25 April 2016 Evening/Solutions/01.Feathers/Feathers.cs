using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Feathers
{
    class Feathers
    {
        static void Main(string[] args)
        {
            double birds = double.Parse(Console.ReadLine());
            double feathersTotal = double.Parse(Console.ReadLine());

            double birdFeathers = feathersTotal / birds;
            //Console.WriteLine(birdFeathers);

            double result = 0;


            if (birds % 2 == 0)
            {
                result = birdFeathers * 123123123123d;
            }
            else
            {
                result = birdFeathers / 317d;
            }
            Console.WriteLine("{0:F4}", result);
        }
    }
}
