using System;
using System.Numerics;

namespace ExamSolutions.Messages
{
    public static class StartUp
    {
        private static readonly string[] System = new string[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        public static void Main()
        {
            string firstInput = Console.ReadLine().Trim();
            string operation = Console.ReadLine().Trim();
            string secondImput = Console.ReadLine().Trim();

            BigInteger firstNumber = ExtractDecimalNumber(firstInput);
            BigInteger secondNumber = ExtractDecimalNumber(secondImput);

            BigInteger resultDecimal = 0;

            if (operation == "-")
            {
                resultDecimal = firstNumber - secondNumber;
            }
            else
            {
                resultDecimal = firstNumber + secondNumber;
            }
            
            string systemResult = ExtractToSystem(resultDecimal);
            Console.WriteLine(systemResult);
        }

        public static string ExtractToSystem(BigInteger resultDecimal)
        {
            string result = string.Empty;

            do
            {
                int digit = (int)(resultDecimal % 10);
                result = System[digit] + result;
                resultDecimal /= 10;
            }
            while (resultDecimal > 0);

            return result;
        }

        public static BigInteger ExtractDecimalNumber(string input)
        {
            BigInteger result = 0;

            for (int i = 0; i < input.Length; i += 3)
            {
                string digit = input.Substring(i, 3);
                int dec = Array.IndexOf(System, digit);
                result = dec + (result * 10);
            }

            return result;
        }
    }
}
