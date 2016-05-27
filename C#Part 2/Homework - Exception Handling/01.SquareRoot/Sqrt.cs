using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Sqrt
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                double number = double.Parse(input);
                if (number <= 0)
                {
                    throw new FormatException("Invalid number");
                }
                double result = Math.Sqrt(number);
                Console.WriteLine("{0:F3}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            } 
        }
    }
}
