using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSAOfNNumbers
{
    class MMSAOfNNumbers
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double[] numbers = new double[lines];

            for (int i = 0; i < lines; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double min = numbers.Min();
            double max = numbers.Max();
            double sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", average);
        }
    }
}
