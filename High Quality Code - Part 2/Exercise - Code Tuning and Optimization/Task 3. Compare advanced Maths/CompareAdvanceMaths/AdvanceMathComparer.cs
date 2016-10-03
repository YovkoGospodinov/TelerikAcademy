using System;
using System.Diagnostics;

namespace CompareAdvanceMaths
{
    public class AdvanceMathComparer
    {
        public const int ExecutionTimes = 1000000;

        public static void Main()
        {
            SquareRootTest();
            NaturalLogarithm();
            Sine();
        }

        public static void SquareRootTest()
        {
            Console.WriteLine("Square root tests:");
            Console.WriteLine(GetTimeResult("Float", () => {
                float result = (float)Math.Sqrt(123.01f);
            }));
            Console.WriteLine(GetTimeResult("Double", () => {
                double result = Math.Sqrt(123.0132131);
            }));
            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimal result = (decimal)Math.Sqrt((double)123.0132131m);
            }));
        }

        public static void NaturalLogarithm()
        {
            Console.WriteLine("Natural logarithm tests:");
            Console.WriteLine(GetTimeResult("Float", () => {
                float result = (float)Math.Log(123.01f);
            }));
            Console.WriteLine(GetTimeResult("Double", () => {
                double result = Math.Log(123.0132131);
            }));
            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimal result = (decimal)Math.Log((double)123.0132131m);
            }));
        }

        public static void Sine()
        {
            Console.WriteLine("Sine tests:");
            Console.WriteLine(GetTimeResult("Float", () => {
                float result = (float)Math.Sin(123.01f);
            }));
            Console.WriteLine(GetTimeResult("Double", () => {
                double result = Math.Sin(123.0132131);
            }));
            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimal result = (decimal)Math.Sin((double)123.0132131m);
            }));
        }

        public static string GetTimeResult(string numberType, Action method)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int time = 0; time < ExecutionTimes; time++)
            {
                method();
            }

            stopWatch.Stop();

            return $"\tWith {numberType} was executed for - {stopWatch.Elapsed.ToString()}.";
        }
    }
}
