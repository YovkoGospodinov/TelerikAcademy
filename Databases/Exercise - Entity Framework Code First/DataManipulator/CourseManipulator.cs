using System;
using System.Collections.Generic;
using DataManipulator.Interfaces;
using StudentSystem.Models;
using System.Linq;
using System.Data.Entity;

namespace DataManipulator
{
    public class CourseManipulator : BaseManipulator, IManipulator<Course>
    {
        public void Create(Course course)
        {
            base.database.Courses.Add(course);
            base.database.SaveChanges();
        }

        public void Delete(int id)
        {
            var courseToDelete = base.database.Courses.FirstOrDefault(c => c.Id == id);

            if (courseToDelete != null)
            {
                base.database.Courses.Remove(courseToDelete);
                base.database.SaveChanges();
            }
        }

        public IEnumerable<Course> GetAll()
        {
            var courses = base.database.Courses.ToList();

            return courses;
        }

        public void Modidy(Course course)
        {
            var entry = base.database.Entry(course);
            entry.State = EntityState.Modified;
            base.database.SaveChanges();
        }
    }
}
