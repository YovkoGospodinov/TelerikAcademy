using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            int totalSheets = sheetsPerStudent * students;
            decimal realm = totalSheets / 400M;
            decimal savedMoney = realm * price;

            Console.WriteLine("{0:F3}", savedMoney);
        }
    }
}
