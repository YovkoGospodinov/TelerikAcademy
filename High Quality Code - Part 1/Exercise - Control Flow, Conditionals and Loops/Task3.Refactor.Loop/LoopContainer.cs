using System;

namespace Task3.Refactor.Loop
{
    public class LoopContainer
    {
        public const int MagicNumber = 666;

        public static void FindValue(int[] array, int value)
        {
            int expectedValue = value;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == expectedValue)
                {
                    Console.WriteLine("Value found!");
                    break;
                }

                if (i == array.Length - 1)
                {
                    Console.WriteLine("Value not found!");
                }
            }
        }
    }
}
