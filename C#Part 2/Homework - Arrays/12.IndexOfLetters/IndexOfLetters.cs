using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] array = new char[26];
            for (int i = 0; i < 26; i++)
            {
                array[i] = (char)(97 + i);
            }

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (word[i] == array[j])
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}
