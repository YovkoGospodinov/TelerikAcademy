using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081.NumberAsArray
{
    class NumberAsArray
    {
        public static string StringReverse(string firstArray)
        {
            char[] ch = firstArray.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }
        public static int SumdigitsArray(byte[] array)
        {
            string temp = "";
            string str = array.ToString();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                temp += array[i];
            }
            return int.Parse(temp);
        }

        public static string NumberToString(int number)
        {
            string output = "";
            string numToString = number.ToString();
            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                output += numToString[i];
                output += " ";
            }
            return output;
        }
        static void Main(string[] args)
        {
            string arraysSize = Console.ReadLine();
            byte[] firstArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray();
            byte[] secondArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(byte.Parse).ToArray(); ;

            int resultNumber = SumdigitsArray(firstArray) + SumdigitsArray(secondArray);

            Console.WriteLine(NumberToString(resultNumber));
        }
    }
}
