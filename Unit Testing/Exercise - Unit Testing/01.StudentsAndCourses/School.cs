namespace _01.StudentsAndCourses
{
    using System.Collections.Generic;

    public class School
    {
        private List<Student> students;
        private List<Course> courses;

        public School()
        {
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        public List<Student> Students => this.students;
        public List<Course> Courses => this.courses;
    }
}