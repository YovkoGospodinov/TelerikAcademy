using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class DevideBy7And5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isDivided = true;

            if (number % 35 != 0)
            {
                isDivided = false;
            }

            if (isDivided)
            {
                Console.WriteLine("{0}{1}{2}", "true", " ", number);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", "false", " ", number);
            }
        }
    }
}
