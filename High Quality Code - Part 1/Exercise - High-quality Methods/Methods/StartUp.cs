using System;

namespace Methods
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(MathematicCalculations.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(StringOperations.GetDigitAsText(5));

            Console.WriteLine(MathematicCalculations.GetMaximumNumber(5, -1, 3, 2, 14, 2, 3));

            StringOperations.PrintNumberWithTwoDigitsPrecision(1.3);
            StringOperations.PrintNumberAsPercentage(0.75);
            StringOperations.PrintNumberRightAllign(2.30);

            Console.WriteLine(MathematicCalculations.GetDistanceBetweenPoints(3, -1, 3, 2.5));
            Console.WriteLine(MathematicCalculations.CheckAlignmentOfLine(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov");
            peter.StudentDetails = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova");
            stella.StudentDetails = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
