using System;
using System.Diagnostics;

namespace CompareMaths
{
    public class MathComparer
    {
        public const int ExecutionTimes = 100000000;
        public static void Main()
        {
            AddTests();
            SubtractTests();
            IncrementTests();
            MultiplyTests();
            DivideTests();
        }
        
        public static void AddTests()
        {
            Console.WriteLine("Add tests:");
            Console.WriteLine(GetTimeResult("Integer", () => {
                int result = 123 + 123123123;
            }));
            Console.WriteLine(GetTimeResult("Long", () => {
                long result = 123 + 123123123123;
            }));
            Console.WriteLine(GetTimeResult("Float", () => {
                float result = 123.01f + 0.1231f;
            }));

            Console.WriteLine(GetTimeResult("Double", () => {
                double result = 123.01 + 0.12311231232131;
            }));

            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimal result = 123.01m + 0.12342342343243243242343231m;
            }));
        }

        public static void SubtractTests()
        {
            Console.WriteLine("Subtrac tests:");
            Console.WriteLine(GetTimeResult("Integer", () => {
                int result = 123 - 123123123;
            }));
            Console.WriteLine(GetTimeResult("Long", () => {
                long result = 123 - 123123123123;
            }));
            Console.WriteLine(GetTimeResult("Float", () => {
                float result = 123.01f - 0.1231f;
            }));

            Console.WriteLine(GetTimeResult("Double", () => {
                double result = 123.01 - 0.12311231232131;
            }));

            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimal result = 123.01m - 0.12342342343243243242343231m;
            }));
        }

        public static void IncrementTests()
        {
            Console.WriteLine("Increment tests:");
            int intSum = 0;
            Console.WriteLine(GetTimeResult("Integer", () => {
                intSum += 1;
            }));
            long longSum = 0;
            Console.WriteLine(GetTimeResult("Long", () => {
                longSum += 1;
            }));
            float floatSum = 0.0f;
            Console.WriteLine(GetTimeResult("Float", () => {
                floatSum += 1;
            }));
            double doubleSum = 0.0;
            Console.WriteLine(GetTimeResult("Double", () => {
                doubleSum += 1;
            }));
            decimal decimalSum = 0m;
            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimalSum += 1;
            }));
        }

        public static void MultiplyTests()
        {
            Console.WriteLine("Multiply tests:");
            Console.WriteLine(GetTimeResult("Integer", () => {
                int result = 123 * 1231;
            }));
            Console.WriteLine(GetTimeResult("Long", () => {
                long result = 123 * 123123123123;
            }));
            Console.WriteLine(GetTimeResult("Float", () => {
                float result = 123.01f * 0.1231f;
            }));

            Console.WriteLine(GetTimeResult("Double", () => {
                double result = 123.01 * 0.12311231232131;
            }));

            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimal result = 123.01m * 0.12342342343243243242343231m;
            }));
        }

        public static void DivideTests()
        {
            Console.WriteLine("Divide tests:");
            Console.WriteLine(GetTimeResult("Integer", () => {
                int result = 123 / 1231;
            }));
            Console.WriteLine(GetTimeResult("Long", () => {
                long result = 123 / 123123123123;
            }));
            Console.WriteLine(GetTimeResult("Float", () => {
                float result = 123.01f / 0.1231f;
            }));

            Console.WriteLine(GetTimeResult("Double", () => {
                double result = 123.01 / 0.12311231232131;
            }));

            Console.WriteLine(GetTimeResult("Decimal", () => {
                decimal result = 123.01m / 0.12342342343243243242343231m;
            }));
        } 

        public static string GetTimeResult(string numberType, Action method)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            for (int times = 0; times < ExecutionTimes; times++)
            {
                method();
            }

            stopWatch.Stop();

            return $"\tWith {numberType} type was executed for - {stopWatch.Elapsed.ToString()}.";
        }
    }
}
