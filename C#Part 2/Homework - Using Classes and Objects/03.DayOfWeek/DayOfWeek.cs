using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime day = DateTime.Now;
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
