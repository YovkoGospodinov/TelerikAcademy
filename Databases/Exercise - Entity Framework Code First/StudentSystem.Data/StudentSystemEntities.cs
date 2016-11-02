using StudentSystem.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StudentSystem.Data
{
    public class StudentSystemEntities : DbContext
    {
        public StudentSystemEntities()
            : base("StudentSystem") { }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
