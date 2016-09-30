using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade should be positive number.");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Min grade should be positive number.");
            }

            this.minGrade = value;
        }
    }
    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }
        private set
        {
            if (value <= this.minGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade should be greater than min grade.");
            }

            this.maxGrade = value;
        }
    }
    public string Comments
    {
        get
        {
            return this.comments;
        }
        private set
        {
            if (value == null || value == String.Empty)
            {
                throw new ArgumentNullException("Comments should not be null or empty.");
            }

            this.comments = value;
        }
    }
}
