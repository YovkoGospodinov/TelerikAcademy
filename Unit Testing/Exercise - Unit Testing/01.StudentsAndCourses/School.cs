namespace _01.StudentsAndCourses
{
    using System.Collections.Generic;

    public class School
    {
        private IList<Student> students;
        private IList<Course> courses;

        public School()
        {
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }
    }
}