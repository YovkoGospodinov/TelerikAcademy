namespace _01.StudentsAndCourses
{
    using System;

    public class Student
    {
        const int ID_LENGTH = 5;

        private string name;
        private string id;
        
        public Student(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Student name can not be empty.");
                }
                this.name = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                if (value.Length != ID_LENGTH)
                {
                    throw new ArgumentOutOfRangeException($"Student id  length must be exactly {ID_LENGTH} symbols.");
                }
                id = value;
            }
        }
    }
}
