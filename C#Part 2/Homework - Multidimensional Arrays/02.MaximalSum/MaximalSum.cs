using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split(' ');
            int row = int.Parse(dimentions[0]);
            int col = int.Parse(dimentions[1]);
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                } 
            }

            int sum = int.MinValue;
            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    int tempSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
