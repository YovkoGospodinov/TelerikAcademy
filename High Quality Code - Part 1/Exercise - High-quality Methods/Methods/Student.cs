using System;

namespace Methods
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentDetails { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            if (otherStudent == null)
            {
                throw new ArgumentNullException("Passed parameter other student is null.");
            }

            DateTime studentBirthDate = ParseDate(this.StudentDetails);
            DateTime otherStudentBirthDate = ParseDate(otherStudent.StudentDetails);

            bool result = studentBirthDate < otherStudentBirthDate;

            return result;
        }

        public DateTime ParseDate(string info)
        {
            if (info == null)
            {
                throw new ArgumentNullException("Passed parameter date is null");
            }

            string dateAsString = info.Substring(info.Length - 10);

            DateTime result = DateTime.ParseExact(dateAsString, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            return result;
        }
    }
}
