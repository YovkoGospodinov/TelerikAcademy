using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04UnicodeChar
{
    class UnicodeChar
    {
        static void Main(string[] args)
        {
            char characterVariable = (char)(42);
            char charVariable = '\u002A';
            Console.WriteLine(characterVariable);
            Console.WriteLine(charVariable);
        }
    }
}
