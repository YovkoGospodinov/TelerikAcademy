using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Decoding
{
    class Decoding
    {
        static void Main()
        {
            int salt = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            double result = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == '@')
                {
                    break;
                }
                else if (((65 <= inputText[i]) && (inputText[i] <= 90)) || ((97 <= inputText[i]) && (inputText[i] <= 122)))
                {
                    result = inputText[i] * salt + 1000;
                    if (i % 2 == 0)
                    {
                        result /= 100;
                        Console.WriteLine("{0:F2}", result);
                    }
                    else
                    {
                        result *= 100;
                        Console.WriteLine(result);
                    }
                    
                }
                else if (((48 <= inputText[i]) && (inputText[i] <= 57)))
                {
                    result = inputText[i] + salt + 500;
                    if (i % 2 == 0)
                    {
                        result /= 100;
                        Console.WriteLine("{0:F2}", result);
                    }
                    else
                    {
                        result *= 100;
                        Console.WriteLine(result);
                    }
                    
                }
                else
                {                    
                    result = inputText[i] - salt;
                    if (i % 2 == 0)
                    {
                        result /= 100;
                        Console.WriteLine("{0:F2}", result);
                    }
                    else
                    {
                        result *= 100;
                        Console.WriteLine(result);
                    }
                    
                }
                
            }

        }
    }
}
