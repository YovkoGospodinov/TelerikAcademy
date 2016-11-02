using System;
using System.Data.Entity;
using System.Linq;
using StudentSystem.Data;
using StudentSystem.Data.Migrations;
using DataManipulator;
using StudentSystem.Models;
using System.Collections.Generic;

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
            var student = new Student()
            {
                Name = "Ivan",
                Number = "13234",
                Grade = 11,
                Courses = new List<Course>()
                {
                    new Course()
                    {
                         
                    };
                };
            };
        }
    }
}
