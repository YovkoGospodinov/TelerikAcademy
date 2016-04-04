using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime birthDate = DateTime.Parse(Console.ReadLine());          
            DateTime now = DateTime.Now;
            TimeSpan years = now - birthDate;
            int age = (int)(years.TotalDays / 365);
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
