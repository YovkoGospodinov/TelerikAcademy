using System;

namespace Task2.Method.PrintStatistics
{
    public static class Statistics
    {
        public static void PrintStatistics(double[] values, int valuesCount)
        {
            double maximumValue = GetMaximumValue(values);
            double minimumValue = GetMinimumValue(values);
            double sumOfAllValues = GetSum(values);
            double averageValue = GetAverageValue(sumOfAllValues, valuesCount);

            Print(maximumValue);
            Print(minimumValue);
            Print(averageValue);
        }

        private static double GetMinimumValue(double[] values)
        {
            double minimumValue = values[0];

            foreach (double value in values)
            {
                if (value < minimumValue)
                {
                    minimumValue = value;
                }
            }

            return minimumValue;
        }

        private static double GetMaximumValue(double[] values)
        {
            double maximumValue = values[0];

            foreach (double value in values)
            {
                if (value > maximumValue)
                {
                    maximumValue = value;
                }
            }

            return maximumValue;
        }

        private static double GetSum(double[] values)
        {
            double sum = 0;

            foreach (double value in values)
            {
                sum += value;
            }

            return sum;
        }

        private static double GetAverageValue(double sumOfAllValues, int valuesCount)
        {
            double averageValue = sumOfAllValues / valuesCount;

            return averageValue;
        }

        private static void Print(double value)
        {
            Console.WriteLine("{0:F2}", value);
        }
    }
}
