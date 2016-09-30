using System;
using System.Collections.Generic;

namespace Exceptions_Homework
{
    public static class MathCalculations
    {
        public static bool CheckPrime(int number)
        {
            double maxDivisor = Math.Sqrt(number);

            for (int divisor = 2; divisor <= maxDivisor; divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array can not be null!");
            }

            if (startIndex < 0 || arr.Length <= startIndex)
            {
                throw new ArgumentOutOfRangeException($"Start index must be between 0 and {arr.Length}");
            }

            if (count < 0 || count > arr.Length)
            {
                throw new ArgumentException($"Count can not be less than 0 or greater than the {arr.Length}!");
            }

            var endIndex = startIndex + count;
            if (endIndex > arr.Length)
            {
                throw new ArgumentOutOfRangeException("endIndex");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }
    }
}
