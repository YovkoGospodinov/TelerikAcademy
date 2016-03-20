using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TextToNumber
{
    class TextToNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == '@')
                {
                    break;
                }
                else if ((65 <= inputText[i] && inputText[i] <= 90) ||(97 <= inputText[i] && inputText[i] <= 122))
                {
                    result += char.ToUpper(inputText[i]) - 65;
                }
                else if (48 <= inputText[i] && inputText[i] <= 57)
                {
                    result *= int.Parse(Convert.ToString(inputText[i]));
                }
                else
                {
                    result %= number;
                }                
            }
            Console.WriteLine(result);
        }
    }
}
