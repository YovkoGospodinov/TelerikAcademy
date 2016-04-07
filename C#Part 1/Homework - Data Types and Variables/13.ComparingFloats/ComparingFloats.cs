using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double difference = Math.Abs(firstNumber - secondNumber);
            
            if (difference >= 0.000001)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
            //works for float type numbers 
            //if (firstNumber.Equals(secondNumber))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
        }
    }
}
