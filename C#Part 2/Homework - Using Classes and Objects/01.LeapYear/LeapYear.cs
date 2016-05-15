using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            int daysInFebruary = DateTime.DaysInMonth(year, 2);
            if (daysInFebruary < 29)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            bool isYearLeap = IsLeapYear(year);
            if (isYearLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
