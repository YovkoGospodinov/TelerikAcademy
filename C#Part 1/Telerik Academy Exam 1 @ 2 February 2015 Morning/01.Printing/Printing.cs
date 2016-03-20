using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Printing
{
    class Printing
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            decimal priceOfOneBoxPaper = decimal.Parse(Console.ReadLine());

            int totalSheets = students * sheetsPerStudent;
            decimal boxesNeeded = totalSheets / 500M;

            decimal expenses = priceOfOneBoxPaper * boxesNeeded;
            Console.WriteLine("{0:F2}", expenses);
        }
    }
}
