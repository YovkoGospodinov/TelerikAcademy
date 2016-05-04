using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Printing
{
    class Printing
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal realmNeeded = (sheetsPerStudent * students) / 500M;
            decimal moneySaved = realmNeeded * price;

            Console.WriteLine("{0:F2}", moneySaved);
        }
    }
}
