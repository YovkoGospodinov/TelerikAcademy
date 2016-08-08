namespace _01.StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        const int MAX_STUDENTS_IN_COURSE = 29;

        private IList<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }

            private set
            {
                if (students.Count > MAX_STUDENTS_IN_COURSE)
                {
                    throw new ArgumentOutOfRangeException("Total number of students in the course must be less than 30. The current number of students in the course is 29, you can not add more students.");
                }
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (students.Count > MAX_STUDENTS_IN_COURSE)
            {
                throw new ArgumentOutOfRangeException("Total number of students in the course must be less than 30. The current number of students in the course is 29, you can not add more students.");
            }

            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            var studentToRemove = Students.SingleOrDefault(st => st.Equals(student));

            if (studentToRemove != null)
            {
                Students.Remove(studentToRemove);
            }
            else
            {
                throw new InvalidOperationException("The student trying to remove does not exist in the course.");
            }
        }
    }
}