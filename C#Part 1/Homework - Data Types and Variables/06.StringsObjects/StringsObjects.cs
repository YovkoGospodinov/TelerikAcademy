using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsObjects
{
    class StringsObjects
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object variable = firstString + " " + secondString;
            string thirdString = (string)variable;
            Console.WriteLine(thirdString);
        }
    }
}
