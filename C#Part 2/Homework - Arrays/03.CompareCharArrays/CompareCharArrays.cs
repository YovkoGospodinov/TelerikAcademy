using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string firstCharArray = Console.ReadLine();
            string secondCharArray = Console.ReadLine();

            if (string.Compare(firstCharArray, secondCharArray) > 0)
            {
                Console.WriteLine(">");
            }
            else if (string.Compare(firstCharArray, secondCharArray) < 0)
            {
                Console.WriteLine("<");
            }
            else if (string.Compare(firstCharArray, secondCharArray) == 0)
            {
                Console.WriteLine("=");
            }
        }
    }
}
