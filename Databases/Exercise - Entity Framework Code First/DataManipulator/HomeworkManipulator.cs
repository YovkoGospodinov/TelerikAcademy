using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataManipulator.Interfaces;
using StudentSystem.Models;

namespace DataManipulator
{
    public class HomeworkManipulator : BaseManipulator, IManipulator<Homework>
    {
        public HomeworkManipulator()
            : base() { }
        public void Create(Homework homework)
        {
            base.database.Homeworks.Add(homework);
            base.database.SaveChanges();
        }

        public void Delete(int id)
        {
            var homeworkToDelete = base.database.Homeworks.FirstOrDefault(h => h.Id == id);

            if (homeworkToDelete != null)
            {
                base.database.Homeworks.Remove(homeworkToDelete);
                base.database.SaveChanges();
            }
        }

        public IEnumerable<Homework> GetAll()
        {
            var homeworks = base.database.Homeworks.ToList();

            return homeworks;
        }

        public void Modidy(Homework homework)
        {
            var entry = base.database.Entry(homework);
            entry.State = EntityState.Modified;
            base.database.SaveChanges();
        }
    }
}
