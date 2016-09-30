using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < 0 || 100 < value)
            {
                throw new ArgumentOutOfRangeException("Score should be positive number no greater than 100.");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.score, 0, 100, "Exam results calculated by score.");
    }
}
