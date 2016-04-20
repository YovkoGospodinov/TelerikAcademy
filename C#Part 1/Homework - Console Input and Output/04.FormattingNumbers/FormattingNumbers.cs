using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("{0, -10}|{1, 10}|{2, 10:F2}|{3, -10:F3}", Convert.ToString(firstNumber, 16), Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);
        }
    }
}
