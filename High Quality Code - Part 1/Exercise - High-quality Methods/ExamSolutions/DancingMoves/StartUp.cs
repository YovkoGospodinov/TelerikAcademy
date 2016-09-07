using System;
using System.Linq;

namespace ExamSolutions.DancingMoves
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            long result = 0;
            int rounds = 0;
            int currentIndex = 0;
            string command = Console.ReadLine();

            while (command != "stop")
            {
                rounds++;

                string[] splittedCommand = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int times = int.Parse(splittedCommand[0]);
                string direction = splittedCommand[1];
                int step = int.Parse(splittedCommand[2]);
                
                for (int i = 0; i < times; i++)
                {
                    if (direction == "right")
                    {
                        int newIndex = (currentIndex + step) % numbers.Length;
                        result += numbers[newIndex];
                        currentIndex = newIndex;
                    }
                    else
                    {
                        int newIndex = currentIndex - (step % numbers.Length);

                        if (newIndex < 0)
                        {
                            newIndex = numbers.Length + newIndex;
                        }

                        result += numbers[newIndex];
                        currentIndex = newIndex;
                    }
                }

                command = Console.ReadLine();
            }

            double newResult = (double)result / (double)rounds;

            Console.WriteLine("{0:F1}", newResult);
        }
    }
}
