using System;

namespace Methods
{
    public static class MathematicCalculations
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The lenght of all triangle side's must be positive values.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        public static double GetDistanceBetweenPoints(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double xDistance = secondPointX - firstPointX;
            double yDistance = secondPointY - firstPointY;

            double distance = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));

            return distance;
        }

        public static string CheckAlignmentOfLine(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            if (firstPointX.Equals(secondPointX) && firstPointY.Equals(secondPointY))
            {
                throw new ArgumentNullException("The points are on the same position. Therefore there is no line.");
            }

            if (firstPointX.Equals(secondPointX))
            {
                return "The line is vertical.";
            }
            else if (firstPointY.Equals(secondPointY))
            {
                return "The line is horizontal.";
            }
            else
            {
                return "The line is tilted at a degree different than 0 and 90.";
            }
        }

        public static int GetMaximumNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Parameter is not valid array.");
            }

            int maximumNumber = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maximumNumber)
                {
                    maximumNumber = elements[i];
                }
            }

            return maximumNumber;
        }
    }
}
