using StudentSystem.Models;
using System.Data.Entity;

namespace StudentSystem.Data
{
    public class StudentSystemEntities : DbContext
    {
        public StudentSystemEntities()
            : base("StudentSystem") { }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }
    }
}
