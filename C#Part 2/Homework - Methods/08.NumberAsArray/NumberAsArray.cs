using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumberAsArray
{
    class NumberAsArray
    {
        public static List<int> SumDigitsArrays(int[] firstArray, int[] secondArray)
        {
            List<int> result = new List<int>();
            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if ((firstArray[i] + secondArray[i]) < 10)
                    {
                        result.Add(firstArray[i] + secondArray[i]);
                    }
                    else
                    {
                        if (i != firstArray.Length - 1)
                        {
                            result.Add((firstArray[i] + secondArray[i]) % 10);
                            firstArray[i + 1] = firstArray[i + 1] + 1;
                        }
                        else
                        {
                            result.Add((firstArray[i] + secondArray[i]) % 10);
                            result.Add(1);
                        }
                    }
                }
            }
            else
            {
                int minLenght = firstArray.Length;
                if (secondArray.Length < firstArray.Length)
                {
                    minLenght = secondArray.Length;
                }
                for (int i = 0; i < minLenght; i++)
                {
                    if (firstArray[i] + secondArray[i] < 10)
                    {
                        if (i != minLenght - 1)
                        {
                            result.Add(firstArray[i] + secondArray[i]);
                        }
                        else
                        {
                            result.Add(firstArray[i] + secondArray[i]);
                            if (firstArray.Length > minLenght)
                            {
                                result.Add(firstArray[i + 1]);
                            }
                            else
                            {
                                result.Add(secondArray[i + 1]);
                            }
                        }
                    }
                    else
                    {
                        if (i != minLenght - 1)
                        {
                            result.Add((firstArray[i] + secondArray[i]) % 10);
                            firstArray[i + 1] = firstArray[i + 1] + 1;
                        }
                        else
                        {
                            if (firstArray.Length > minLenght)
                            {
                                result.Add((firstArray[i] + secondArray[i]) % 10);
                                if ((firstArray[i + 1] + 1) < 10)
                                {
                                    result.Add(firstArray[i + 1] + 1);
                                }
                                else
                                {
                                    result.Add((firstArray[i + 1] + 1) % 10);
                                    result.Add(1);
                                }
                            }
                            else
                            {
                                result.Add((firstArray[i] + secondArray[i]) % 10);
                                if ((secondArray[i + 1] + 1) < 10)
                                {
                                    result.Add(secondArray[i + 1] + 1);
                                }
                                else
                                {
                                    result.Add((secondArray[i + 1] + 1) % 10);
                                    result.Add(1);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] arraysSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (int digit in SumDigitsArrays(firstNumber, secondNumber))
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
        }
    }
}
