using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MatrixFill
{
    class MatrixFill
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[,] matrix = new int[n, n];
            int number = 1;
            switch (input)
            {
                case "a":
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix[j, i] = number++;
                        }
                    }
                    break;
                case "b":
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                matrix[j, i] = number++;
                            }
                        }
                        else
                        {
                            for (int j = n - 1; j >= 0; j--)
                            {
                                matrix[j, i] = number++;
                            }
                        }
                    }
                    break;
                case "c":
                    for (int i = n - 1; i >= 0; i--)
                    {
                        int col = 0;
                        int realRow = i;
                        do
                        {
                            matrix[realRow, col] = number;
                            col++;
                            number++;
                            realRow++;
                        } while (realRow <= matrix.GetLength(0) - 1);
                    }
                    for (int i = 1; i < n; i++)
                    {
                        int col = i;
                        int realRow = 0;
                        do
                        {
                            matrix[realRow, col] = number;
                            col++;
                            number++;
                            realRow++;
                        } while (col <= matrix.GetLength(1) - 1);
                    }
                    break;
                case "d":
                    int r = n;
                    int count = 0;
                    do
                    {
                        for (int i = 0; i < r; i++)
                        {
                            matrix[i + count, 0 + count] = number++;
                        }
                        for (int i = 1; i < r; i++)
                        {
                            matrix[r - 1 + count, i + count] = number++;
                        }
                        for (int i = r - 2; i >= 0; i--)
                        {
                            matrix[i + count, r - 1 + count] = number++;
                        }
                        for (int i = r - 2; i > 0; i--)
                        {
                            matrix[0 + count, i + count] = number++;
                        }
                        r -= 2;
                        count++;
                    } while (r > 0);
                    break;
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j != n - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

