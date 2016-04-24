using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "2":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "3":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "4":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "5":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "6":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "7":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "8":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "9":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "10":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "J":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "Q":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "K":
                    Console.WriteLine("yes {0}", input);
                    break;
                case "A":
                    Console.WriteLine("yes {0}", input);
                    break;
                default:
                    Console.WriteLine("no {0}", input);
                    break;
            }
        }
    }
}
