using System;
using System.Collections.Generic;
using Exceptions_Homework;

public class ExceptionsHomework
{
    static void Main()
    {
        try
        {
            var subString = MathCalculations.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(subString);

            var subArray = MathCalculations.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subArray));

            var allArray = MathCalculations.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allArray));

            var emptyArray = MathCalculations.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyArray));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine(StringManipulations.ExtractEnding("I love C#", 2));
            Console.WriteLine(StringManipulations.ExtractEnding("Nakov", 4));
            Console.WriteLine(StringManipulations.ExtractEnding("beer", 4));
            Console.WriteLine(StringManipulations.ExtractEnding("Hi", 100));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // The app should not throw exceptions when checking whether number is prime.
        var numbers = new int[] { 23, 33 };

        foreach (var number in numbers)
        {
            bool isPrime = MathCalculations.CheckPrime(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} is prime!");
            }
            else
            {
                Console.WriteLine($"{number} is not prime!");
            }
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
