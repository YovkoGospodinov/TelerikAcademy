using System.Collections.Generic;
using System.Linq;
using StudentSystem.Models;
using DataManipulator.Interfaces;
using System.Data.Entity;

namespace DataManipulator
{
    public class StudentsManipulator : BaseManipulator, IManipulator<Student>
    {
        public StudentsManipulator()
            : base() { }
        public void Create(Student student)
        {
            base.database.Students.Add(student);
        }

        public void Delete(int id)
        {
            Student studentToDelete = base.database.Students.FirstOrDefault(st => st.Id == id);

            if (studentToDelete != null)
            {
                base.database.Students.Remove(studentToDelete);
                base.database.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            var students = base.database.Students.ToList();

            return students;
        }

        public void Modidy(Student student)
        {
            var entry = database.Entry(student);
            entry.State = EntityState.Modified;
            database.SaveChanges();
        }
    }
}
