using System;

namespace Methods
{
    public static class StringOperations
    {
        public static string GetDigitAsText(int number)
        {
            if (number < 0 || number > 9)
            {
                throw new ArgumentOutOfRangeException("Parameter is not valid digit.");
            }

            string[] digitsAsString = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string digitAsString = digitsAsString[number];
            
            // The other refactored way using switch case.
            // switch (number)
            // {
            //    case 0:
            //        digitAsString = "zero";
            //        break;
            //    case 1:
            //        digitAsString = "one";
            //        break;
            //    case 2:
            //        digitAsString = "two";
            //        break;
            //    case 3:
            //        digitAsString = "three";
            //        break;
            //    case 4:
            //        digitAsString = "four";
            //        break;
            //    case 5:
            //        digitAsString = "five";
            //        break;
            //    case 6:
            //        digitAsString = "six";
            //        break;
            //    case 7:
            //        digitAsString = "seven";
            //        break;
            //    case 8:
            //        digitAsString = "eight";
            //        break;
            //    case 9:
            //        digitAsString = "nine";
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException("Parameter is not valid digit.");
            // }
            return digitAsString;
        }

        public static void PrintNumberWithTwoDigitsPrecision(object number)
        {
            Console.WriteLine("{0:F2}", number);
        }

        public static void PrintNumberAsPercentage(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintNumberRightAllign(object number)
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}
