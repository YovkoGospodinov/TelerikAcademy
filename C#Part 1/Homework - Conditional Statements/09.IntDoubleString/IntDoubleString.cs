using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string inputCommand = Console.ReadLine();
            if (inputCommand == "integer")
            {
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
            }
            else if (inputCommand == "real")
            {
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", doubleNumber + 1);
            }
            else
            {
                string text = Console.ReadLine();
                Console.WriteLine("{0}{1}", text, "*");
            }
        }
    }
}
