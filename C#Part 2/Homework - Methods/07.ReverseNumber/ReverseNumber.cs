using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        private static decimal NumberReverse(decimal number)
        {
            char[] numberText = number.ToString().ToCharArray();
            for (int i = 0; i < numberText.Length/2; i++)
            {
                char temp = numberText[numberText.Length - 1 - i];
                numberText[numberText.Length - 1 - i] = numberText[i];
                numberText[i] = temp;
            }
            string newNumberText = new string(numberText);
            decimal reversedNumber = decimal.Parse(newNumberText);
            return reversedNumber;
        }
        static void Main(string[] args)
        {
            decimal givenNumber = decimal.Parse(Console.ReadLine());
            decimal reverseGivenNumber = NumberReverse(givenNumber);
            Console.WriteLine(reverseGivenNumber);
        }
    }
}
