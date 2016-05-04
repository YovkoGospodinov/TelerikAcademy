using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Busses
{
    class Busses
    {
        static void Main(string[] args)
        {
            int numberOfBusses = int.Parse(Console.ReadLine());
            int lastSpeed = 0;
            int groups = 0;

            for (int i = 0; i < numberOfBusses; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    lastSpeed = speed;
                }
                if (speed > lastSpeed)
                {
                    speed = lastSpeed;
                }
                else
                {
                    groups++;
                    lastSpeed = speed;
                }
            }
            Console.WriteLine(groups);

        }
    }
}
