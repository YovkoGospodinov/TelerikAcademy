using System;
using System.Data.Entity;
using System.Linq;
using StudentSystem.Data;
using StudentSystem.Data.Migrations;
using DataManipulator;

namespace StudentSystem.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemEntities, Configuration>());
            //using (var ctx = new StudentSystemEntities())
            //{
            //    Console.WriteLine(ctx.Courses.Count());
            //}

            var manipulator = new StudentsManipulator();
            var students = manipulator.GetAll();

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
