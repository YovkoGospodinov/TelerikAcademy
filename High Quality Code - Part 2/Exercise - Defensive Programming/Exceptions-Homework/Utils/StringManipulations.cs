using System;
using System.Text;

namespace Exceptions_Homework
{
    public static class StringManipulations
    {
        public static string ExtractEnding(string inputString, int count)
        {
            if (count > inputString.Length)
            {
                throw new ArgumentOutOfRangeException("Count can not be greater than inputed string length.");
            }

            StringBuilder result = new StringBuilder();
            int startIndex = inputString.Length - count;
            for (int i = startIndex; i < inputString.Length; i++)
            {
                result.Append(inputString[i]);
            }
            return result.ToString();
        }
    }
}
