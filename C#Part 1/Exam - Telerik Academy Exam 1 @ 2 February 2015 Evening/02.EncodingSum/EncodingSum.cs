using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TextToNumber
{
    class TextToNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            long result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if (text[i] >= 48 && 57 >= text[i])
                {
                    result *= (int)Char.GetNumericValue(text[i]);
                }
                else if ((text[i] > 65 && 90 >= text[i]) || (text[i] > 97 && 122 >= text[i]))
                {
                    if (text[i] > 65 && 90 >= text[i])
                    {
                        result += text[i] - 65;
                    }
                    else
                    {
                        result += text[i] - 97;
                    }
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
