using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            switch (card)
            {
                case "2":
                    for (int i = 1; i < 2; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "3":
                    for (int i = 1; i < 3; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "4":
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "5":
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "6":
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "7":
                    for (int i = 1; i < 7; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "8":
                    for (int i = 1; i < 8; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "9":
                    for (int i = 1; i < 9; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "10":
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    break;
                case "J":
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    break;
                case "Q":
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    break;
                case "K":
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    break;
                case "A":
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i + 1);
                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                    break;
            }
        }
    }
}
