using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomials
{
    class AddingPolynomials
    {
        public static int[] SumPolinom(int[] firstPoly, int[] secondPoly)
        {
            if (firstPoly.Length < secondPoly.Length)
            {
                return SumPolinom(secondPoly, firstPoly);
            }

            int[] sumOfPoly = new int[firstPoly.Length];

            for (int i = 0; i < secondPoly.Length; i++)
            {
                sumOfPoly[i] = firstPoly[i] + secondPoly[i];
            }

            for (int i = secondPoly.Length; i < firstPoly.Length; i++)
            {
                sumOfPoly[i] = firstPoly[i];
            }

            return sumOfPoly;
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sum = SumPolinom(firstArray, secondArray);

            List<int> list = new List<int>();
            for (int i = 0; i < sum.Length; i++)
            {
                list.Add(sum[i]);
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}

